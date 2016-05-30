#version 110

uniform float hue;
uniform vec2 rainbow;
uniform vec2 monitors;
uniform vec2 texWrap;
uniform vec2 texMove;
uniform vec3 correctPreRGB;
uniform vec3 correctPostRGB;
uniform vec3 correctHSV;

uniform sampler2D texture;

vec3 rgb2hsv(vec3 c)
{
    vec4 K = vec4(0.0, -1.0 / 3.0, 2.0 / 3.0, -1.0);
    vec4 p = mix(vec4(c.bg, K.wz), vec4(c.gb, K.xy), step(c.b, c.g));
    vec4 q = mix(vec4(p.xyw, c.r), vec4(c.r, p.yzx), step(p.x, c.r));

    float d = q.x - min(q.w, q.y);
    float e = 1.0e-10;
    return vec3(abs(q.z + (q.w - q.y) / (6.0 * d + e)), d / (q.x + e), q.x);
}

vec3 hsv2rgb(vec3 c)
{
    vec4 K = vec4(1.0, 2.0 / 3.0, 1.0 / 3.0, 3.0);
    vec3 p = abs(fract(c.xxx + K.xyz) * 6.0 - K.www);
    return c.z * mix(K.xxx, clamp(p - K.xxx, 0.0, 1.0), c.y);
}

void main(void)
{
	// texture pos per monitor
	vec2 pos = gl_TexCoord[0].st * monitors * texWrap + texMove;

	// get color from texture
	vec4 rgb = clamp(texture2D(texture, pos).rgba * gl_Color.rgba + vec4(correctPreRGB, 0.0), 0.0, 1.0);
	
	// convert RGB to HSV
	vec3 hsv = rgb2hsv(rgb.rgb);
	hsv.r = mod(hsv.r + correctHSV.r + 1.0, 1.0);
	hsv.g = clamp(hsv.g + correctHSV.g, 0.0, 1.0);
	hsv.b = clamp(hsv.b + correctHSV.b, 0.0, 1.0);
	
	// HSV Transformation
	vec2 speed = abs(monitors) * abs(texWrap) * abs(rainbow) * hue;
	vec2 skew =  speed + rainbow.st * pos.st;
	hsv.r = mod(hsv.r + 1.0 + hue + skew.s + skew.t, 1.0);
	
	// output color
	gl_FragColor = clamp(vec4(hsv2rgb(hsv), rgb.a) + vec4(correctPostRGB, 0.0), 0.0, 1.0);
}