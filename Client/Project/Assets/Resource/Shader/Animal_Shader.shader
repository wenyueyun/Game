// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:0,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:9361,x:33290,y:32274,varname:node_9361,prsc:2|emission-544-OUT,custl-3836-OUT;n:type:ShaderForge.SFN_NormalVector,id:9684,x:31789,y:32965,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:7782,x:32081,y:32882,cmnt:Lambert,varname:node_7782,prsc:2,dt:1|A-1082-OUT,B-9684-OUT;n:type:ShaderForge.SFN_Tex2d,id:851,x:32217,y:32373,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:node_851,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:1941,x:32865,y:32888,cmnt:Diffuse Contribution,varname:node_1941,prsc:2|A-544-OUT,B-7004-RGB;n:type:ShaderForge.SFN_Color,id:5927,x:32217,y:32542,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_5927,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Multiply,id:544,x:32716,y:32373,cmnt:Diffuse Color,varname:node_544,prsc:2|A-851-RGB,B-5927-RGB,C-6852-OUT;n:type:ShaderForge.SFN_Vector4Property,id:6885,x:31624,y:32813,ptovrint:False,ptlb:Light_Dir,ptin:_Light_Dir,varname:node_6885,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1,v2:0,v3:0,v4:0;n:type:ShaderForge.SFN_Color,id:5984,x:32448,y:33295,ptovrint:False,ptlb:Light_color,ptin:_Light_color,varname:node_5984,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.375,c2:0.2040441,c3:0.2040441,c4:1;n:type:ShaderForge.SFN_Multiply,id:7437,x:32706,y:33294,varname:node_7437,prsc:2|A-5984-RGB,B-7882-OUT;n:type:ShaderForge.SFN_Slider,id:7882,x:32224,y:33640,ptovrint:False,ptlb:Light_intensity,ptin:_Light_intensity,varname:node_7882,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Append,id:4767,x:32240,y:32892,varname:node_4767,prsc:2|A-7782-OUT,B-7782-OUT;n:type:ShaderForge.SFN_Tex2d,id:7004,x:32414,y:32892,ptovrint:False,ptlb:Ramp,ptin:_Ramp,varname:node_7004,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:32ca459621c898d4c974f93c9d725a4b,ntxv:0,isnm:False|UVIN-4767-OUT;n:type:ShaderForge.SFN_Multiply,id:3836,x:33135,y:32890,varname:node_3836,prsc:2|A-1941-OUT,B-7437-OUT;n:type:ShaderForge.SFN_Normalize,id:1082,x:31789,y:32813,varname:node_1082,prsc:2|IN-6885-XYZ;n:type:ShaderForge.SFN_Lerp,id:6852,x:32564,y:32566,varname:node_6852,prsc:2|A-5997-OUT,B-7004-RGB,T-806-OUT;n:type:ShaderForge.SFN_Vector3,id:5997,x:32365,y:32566,varname:node_5997,prsc:2,v1:1,v2:1,v3:1;n:type:ShaderForge.SFN_Slider,id:806,x:32257,y:32726,ptovrint:False,ptlb:Lightness,ptin:_Lightness,varname:node_806,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;proporder:851-5927-6885-5984-7882-7004-806;pass:END;sub:END;*/

Shader "Custom/Animal_Shader" {
    Properties {
        _Diffuse ("Diffuse", 2D) = "white" {}
        _Color ("Color", Color) = (0.5,0.5,0.5,1)
        _Light_Dir ("Light_Dir", Vector) = (1,0,0,0)
        _Light_color ("Light_color", Color) = (0.375,0.2040441,0.2040441,1)
        _Light_intensity ("Light_intensity", Range(0, 10)) = 1
        _Ramp ("Ramp", 2D) = "white" {}
        _Lightness ("Lightness", Range(0, 1)) = 0
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
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal 
            #pragma target 3.0
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform float4 _Color;
            uniform float4 _Light_Dir;
            uniform float4 _Light_color;
            uniform float _Light_intensity;
            uniform sampler2D _Ramp; uniform float4 _Ramp_ST;
            uniform float _Lightness;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                UNITY_FOG_COORDS(2)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.pos = UnityObjectToClipPos(v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
////// Lighting:
////// Emissive:
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(i.uv0, _Diffuse));
                float node_7782 = max(0,dot(normalize(_Light_Dir.rgb),i.normalDir)); // Lambert
                float2 node_4767 = float2(node_7782,node_7782);
                float4 _Ramp_var = tex2D(_Ramp,TRANSFORM_TEX(node_4767, _Ramp));
                float3 node_544 = (_Diffuse_var.rgb*_Color.rgb*lerp(float3(1,1,1),_Ramp_var.rgb,_Lightness)); // Diffuse Color
                float3 emissive = node_544;
                float3 finalColor = emissive + ((node_544*_Ramp_var.rgb)*(_Light_color.rgb*_Light_intensity));
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
