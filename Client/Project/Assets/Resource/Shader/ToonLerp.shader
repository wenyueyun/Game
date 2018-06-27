// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:0,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:34028,y:32728,varname:node_3138,prsc:2|emission-6223-OUT,custl-4950-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:31880,y:32203,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8,c2:0.8,c3:0.8,c4:1;n:type:ShaderForge.SFN_Tex2d,id:2995,x:31896,y:31897,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_2995,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:6223,x:32357,y:32146,varname:node_6223,prsc:2|A-2995-RGB,B-7241-RGB;n:type:ShaderForge.SFN_LightVector,id:7603,x:31027,y:33104,varname:node_7603,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:5587,x:31027,y:32889,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:3780,x:31278,y:32991,varname:node_3780,prsc:2,dt:0|A-5587-OUT,B-7603-OUT;n:type:ShaderForge.SFN_Multiply,id:6791,x:31535,y:32965,varname:node_6791,prsc:2|A-3780-OUT,B-4057-OUT;n:type:ShaderForge.SFN_Vector1,id:4057,x:31370,y:33161,varname:node_4057,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Add,id:9873,x:31761,y:33020,varname:node_9873,prsc:2|A-6791-OUT,B-4057-OUT;n:type:ShaderForge.SFN_LightColor,id:5509,x:32348,y:33087,varname:node_5509,prsc:2;n:type:ShaderForge.SFN_Multiply,id:3584,x:32640,y:32703,varname:node_3584,prsc:2|A-6223-OUT,B-3-RGB,C-5509-RGB;n:type:ShaderForge.SFN_LightAttenuation,id:9870,x:32681,y:33104,varname:node_9870,prsc:2;n:type:ShaderForge.SFN_Multiply,id:4950,x:33481,y:32865,varname:node_4950,prsc:2|A-1381-OUT,B-9870-OUT,C-1769-OUT;n:type:ShaderForge.SFN_Vector1,id:1769,x:32877,y:33323,varname:node_1769,prsc:2,v1:2;n:type:ShaderForge.SFN_Tex2d,id:3,x:32239,y:32900,ptovrint:False,ptlb:Ramp,ptin:_Ramp,cmnt:Diffuse,varname:node_3,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:eddd8acef70781d449de90cc327d6aea,ntxv:0,isnm:False|UVIN-4146-OUT;n:type:ShaderForge.SFN_Append,id:4146,x:31981,y:32751,varname:node_4146,prsc:2|A-9873-OUT,B-9873-OUT;n:type:ShaderForge.SFN_Lerp,id:1381,x:33282,y:32694,varname:node_1381,prsc:2|A-128-RGB,B-3584-OUT,T-5651-OUT;n:type:ShaderForge.SFN_Slider,id:3775,x:32667,y:32877,ptovrint:False,ptlb:TexLerpVale,ptin:_TexLerpVale,varname:node_3775,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Color,id:128,x:32643,y:32368,ptovrint:False,ptlb:TexLerpColor,ptin:_TexLerpColor,varname:node_128,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_RemapRange,id:5651,x:33036,y:32825,varname:node_5651,prsc:2,frmn:0,frmx:1,tomn:0.5,tomx:1|IN-3775-OUT;proporder:7241-2995-3-3775-128;pass:END;sub:END;*/

Shader "Custom/Toon/Lerp" {
    Properties {
        _Color ("Color", Color) = (0.8,0.8,0.8,1)
        _MainTex ("MainTex", 2D) = "white" {}
        _Ramp ("Ramp", 2D) = "white" {}
        _TexLerpVale ("TexLerpVale", Range(0, 1)) = 1
        _TexLerpColor ("TexLerpColor", Color) = (1,1,1,1)
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _Color;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform sampler2D _Ramp; uniform float4 _Ramp_ST;
            uniform float _TexLerpVale;
            uniform float4 _TexLerpColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos(v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
////// Emissive:
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float3 node_6223 = (_MainTex_var.rgb*_Color.rgb);
                float3 emissive = node_6223;
                float node_4057 = 0.5;
                float node_9873 = ((dot(i.normalDir,lightDirection)*node_4057)+node_4057);
                float2 node_4146 = float2(node_9873,node_9873);
                float4 _Ramp_var = tex2D(_Ramp,TRANSFORM_TEX(node_4146, _Ramp)); // Diffuse
                float3 finalColor = emissive + (lerp(_TexLerpColor.rgb,(node_6223*_Ramp_var.rgb*_LightColor0.rgb),(_TexLerpVale*0.5+0.5))*attenuation*2.0);
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
