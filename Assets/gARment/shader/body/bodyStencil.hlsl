void bodyStencil(float2 i_uv, float4 _ScreenParams, sampler2D _CameraDepthTexture, sampler2D _CameraStencilTexture, out float depth, out float stencil)
{
    #if UNITY_UV_STARTS_AT_TOP
    float scale = -1.0;
    #else
    float scale = 1.0;
    #endif
    float2 uv = i_uv * _ScreenParams.xy + _ScreenParams.zw;
    depth = tex2D(_CameraDepthTexture, uv).r;
    stencil = tex2D(_CameraStencilTexture, uv).r;
}