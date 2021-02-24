#version 110

uniform float hue;
uniform vec2 rainbow;

uniform vec2 monitors;
uniform vec2 texWrap;
uniform vec2 texMove;

varying vec2 speed;

void main(void)
{
    // vertex position
    gl_Position = gl_ModelViewProjectionMatrix * gl_Vertex;

    // texture position
    vec2 tex = monitors * texWrap;
    gl_TexCoord[0].st = (gl_MultiTexCoord0.st * tex.st) + texMove.st;

    // vertex color
    gl_FrontColor = gl_Color;

    // speed
    speed = abs(monitors) * abs(texWrap) * abs(rainbow) * hue;
}