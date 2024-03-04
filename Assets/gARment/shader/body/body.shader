Shader "Unlit/body"
{
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        Pass
        {
            Zwrite Off
        
            ColorMask 0

            Stencil
            {
                Ref 1
                Comp Always
                Pass Replace
            }



        }
    }
}
