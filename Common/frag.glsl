#version 110

uniform float hue;
uniform float intensity;
uniform vec2 rainbow;
uniform vec4 correctPreRGB;
uniform vec4 correctPostRGB;
uniform vec4 correctHSV;

uniform sampler2D texture;

in vec2 speed;

const vec4 one = vec4(1.0);

vec4 rgb2hsv(vec4 c)
{
    const vec4 K = vec4(0.0, -1.0 / 3.0, 2.0 / 3.0, -1.0);
    vec4 p = mix(vec4(c.bg, K.wz), vec4(c.gb, K.xy), step(c.b, c.g));
    vec4 q = mix(vec4(p.xyw, c.r), vec4(c.r, p.yzx), step(p.x, c.r));

    float d = q.x - min(q.w, q.y);
    const float e = 1.0e-10;
    return vec4(abs(q.z + (q.w - q.y) / (6.0 * d + e)), d / (q.x + e), q.x, c.a);
}

vec4 hsv2rgb(vec4 c)
{
    const vec4 K = vec4(1.0, 2.0 / 3.0, 1.0 / 3.0, 3.0);
    vec3 p = abs(fract(c.xxx + K.xyz) * 6.0 - K.www);
    return vec4(c.zzz * mix(K.xxx, clamp(p - K.xxx, 0.0, 1.0), c.y), c.a);
}

void main(void)
{
    // texture pos
    vec2 pos = gl_TexCoord[0].st;

    // get color from texture
    vec4 rgb = clamp(texture2D(texture, pos) + correctPreRGB, 0.0, 1.0);

    // RGB to HSV and HSV correction
    vec4 hsv = rgb2hsv(rgb) + correctHSV;
    hsv.gb = clamp(hsv.gb, 0.0, 1.0);

    // Hue Transformation
    vec2 skew = (rainbow * pos) + speed;
    hsv.r = mod(hsv.r + hue + dot(skew, one.st), 1.0);
    
    // output color
    gl_FragColor = mix(rgb, hsv2rgb(hsv) + correctPostRGB, intensity);
}