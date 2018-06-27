// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:0,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:9361,x:34571,y:32747,varname:node_9361,prsc:2|emission-4604-OUT,custl-5085-OUT;n:type:ShaderForge.SFN_LightAttenuation,id:8068,x:32563,y:33119,varname:node_8068,prsc:2;n:type:ShaderForge.SFN_LightColor,id:3406,x:32734,y:32952,varname:node_3406,prsc:2;n:type:ShaderForge.SFN_LightVector,id:6869,x:30309,y:32754,varname:node_6869,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:9684,x:30832,y:33019,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:7782,x:31240,y:32931,cmnt:Lambert,varname:node_7782,prsc:2,dt:0|A-1759-OUT,B-9684-OUT;n:type:ShaderForge.SFN_Tex2d,id:851,x:32070,y:32349,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:node_851,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:1941,x:32505,y:32734,cmnt:Diffuse Contribution,varname:node_1941,prsc:2|A-544-OUT,B-1315-RGB;n:type:ShaderForge.SFN_Color,id:5927,x:32016,y:32582,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_5927,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8,c2:0.8,c3:0.8,c4:1;n:type:ShaderForge.SFN_Multiply,id:5085,x:33194,y:32938,cmnt:Attenuate and Color,varname:node_5085,prsc:2|A-1941-OUT,B-3406-RGB,C-616-OUT;n:type:ShaderForge.SFN_Multiply,id:544,x:32289,y:32557,cmnt:Diffuse Color,varname:node_544,prsc:2|A-851-RGB,B-5927-RGB;n:type:ShaderForge.SFN_Multiply,id:616,x:32801,y:33185,varname:node_616,prsc:2|A-8068-OUT,B-4110-OUT;n:type:ShaderForge.SFN_Vector1,id:4110,x:32582,y:33290,varname:node_4110,prsc:2,v1:2;n:type:ShaderForge.SFN_Vector1,id:5283,x:31172,y:33196,varname:node_5283,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:8435,x:31456,y:32978,varname:node_8435,prsc:2|A-7782-OUT,B-5283-OUT;n:type:ShaderForge.SFN_Add,id:3160,x:31648,y:33113,varname:node_3160,prsc:2|A-8435-OUT,B-5283-OUT;n:type:ShaderForge.SFN_Tex2d,id:1315,x:32179,y:32880,ptovrint:False,ptlb:Ramp,ptin:_Ramp,varname:node_1315,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f7ffef0b7b0a2a34bbcf8ee696ad3249,ntxv:0,isnm:False|UVIN-3852-OUT;n:type:ShaderForge.SFN_Append,id:3852,x:31887,y:33098,varname:node_3852,prsc:2|A-3160-OUT,B-3160-OUT;n:type:ShaderForge.SFN_Step,id:8403,x:32999,y:32149,varname:node_8403,prsc:2|A-3370-OUT,B-1062-R;n:type:ShaderForge.SFN_Tex2d,id:1062,x:32416,y:32119,ptovrint:False,ptlb:EmisMask,ptin:_EmisMask,varname:node_1062,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9d3699ac126a8494c91b423f89c5ea8c,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Vector1,id:3370,x:32613,y:31934,varname:node_3370,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:3760,x:33293,y:32322,varname:node_3760,prsc:2|A-8403-OUT,B-518-RGB,C-544-OUT;n:type:ShaderForge.SFN_Color,id:518,x:32600,y:32271,ptovrint:False,ptlb:EmisTint,ptin:_EmisTint,varname:node_518,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5019608,c2:0.5019608,c3:0.5019608,c4:1;n:type:ShaderForge.SFN_Normalize,id:1759,x:30720,y:32798,varname:node_1759,prsc:2|IN-6869-OUT;n:type:ShaderForge.SFN_Add,id:9081,x:33518,y:32607,varname:node_9081,prsc:2|A-3760-OUT,B-544-OUT;n:type:ShaderForge.SFN_Lerp,id:4604,x:34225,y:32255,varname:node_4604,prsc:2|A-9081-OUT,B-1723-RGB,T-6855-OUT;n:type:ShaderForge.SFN_Slider,id:6855,x:33797,y:32565,ptovrint:False,ptlb:ColorLerpValue,ptin:_ColorLerpValue,varname:node_6855,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Color,id:1723,x:33930,y:32372,ptovrint:False,ptlb:InRopeColor,ptin:_InRopeColor,varname:node_1723,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9896551,c2:1,c3:0.25,c4:1;proporder:5927-851-1315-1062-518-6855-1723;pass:END;sub:END;*/

Shader "Custom/Toon/LitEmissive" {
    Properties {
        _Color ("Color", Color) = (0.8,0.8,0.8,1)
        _Diffuse ("Diffuse", 2D) = "white" {}
        _Ramp ("Ramp", 2D) = "white" {}
        _EmisMask ("EmisMask", 2D) = "white" {}
        _EmisTint ("EmisTint", Color) = (0.5019608,0.5019608,0.5019608,1)
        _ColorLerpValue ("ColorLerpValue", Range(0, 1)) = 0
        _InRopeColor ("InRopeColor", Color) = (0.9896551,1,0.25,1)
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
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x 
            #pragma target 3.0
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform float4 _Color;
            uniform sampler2D _Ramp; uniform float4 _Ramp_ST;
            uniform sampler2D _EmisMask; uniform float4 _EmisMask_ST;
            uniform float4 _EmisTint;
            uniform float _ColorLerpValue;
            uniform float4 _InRopeColor;
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
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos(v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
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
                float4 _EmisMask_var = tex2D(_EmisMask,TRANSFORM_TEX(i.uv0, _EmisMask));
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(i.uv0, _Diffuse));
                float3 node_544 = (_Diffuse_var.rgb*_Color.rgb); // Diffuse Color
                float3 emissive = lerp(((step(1.0,_EmisMask_var.r)*_EmisTint.rgb*node_544)+node_544),_InRopeColor.rgb,_ColorLerpValue);
                float node_5283 = 0.5;
                float node_3160 = ((dot(normalize(lightDirection),i.normalDir)*node_5283)+node_5283);
                float2 node_3852 = float2(node_3160,node_3160);
                float4 _Ramp_var = tex2D(_Ramp,TRANSFORM_TEX(node_3852, _Ramp));
                float3 finalColor = emissive + ((node_544*_Ramp_var.rgb)*_LightColor0.rgb*(attenuation*2.0));
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
