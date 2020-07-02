// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:7309,x:33080,y:32774,varname:node_7309,prsc:2|diff-6791-OUT,spec-3927-OUT,gloss-721-OUT,emission-455-OUT,transm-816-OUT,alpha-9110-OUT,refract-4247-OUT;n:type:ShaderForge.SFN_Fresnel,id:4783,x:32464,y:33935,varname:node_4783,prsc:2|EXP-4918-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4918,x:32224,y:34000,ptovrint:False,ptlb:opacity power,ptin:_opacitypower,varname:node_4918,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.9;n:type:ShaderForge.SFN_NormalVector,id:5908,x:31489,y:32034,prsc:2,pt:False;n:type:ShaderForge.SFN_Transform,id:7691,x:31676,y:32034,varname:node_7691,prsc:2,tffrom:0,tfto:3|IN-5908-OUT;n:type:ShaderForge.SFN_ComponentMask,id:6758,x:31858,y:32034,varname:node_6758,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-7691-XYZ;n:type:ShaderForge.SFN_RemapRange,id:3158,x:32041,y:32034,varname:node_3158,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-6758-OUT;n:type:ShaderForge.SFN_Tex2d,id:488,x:32214,y:32034,ptovrint:False,ptlb:matcap texture,ptin:_matcaptexture,varname:node_488,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:83bd708e5cc92fb4a8442ac2c17c2403,ntxv:0,isnm:False|UVIN-3158-OUT;n:type:ShaderForge.SFN_Slider,id:2638,x:32315,y:34147,ptovrint:False,ptlb:opacity intensity,ptin:_opacityintensity,varname:node_2638,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1,max:1;n:type:ShaderForge.SFN_Add,id:8315,x:32715,y:34133,varname:node_8315,prsc:2|A-4783-OUT,B-2638-OUT;n:type:ShaderForge.SFN_Clamp01,id:8057,x:32898,y:34133,varname:node_8057,prsc:2|IN-8315-OUT;n:type:ShaderForge.SFN_Slider,id:3927,x:32340,y:32831,ptovrint:False,ptlb:specular,ptin:_specular,varname:node_3927,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.365328,max:2;n:type:ShaderForge.SFN_Slider,id:816,x:32340,y:33024,ptovrint:False,ptlb:transmission,ptin:_transmission,varname:node_816,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3463756,max:1;n:type:ShaderForge.SFN_Slider,id:721,x:32340,y:32925,ptovrint:False,ptlb:gloss,ptin:_gloss,varname:node_721,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.8,max:1;n:type:ShaderForge.SFN_Multiply,id:455,x:32451,y:32647,varname:node_455,prsc:2|A-4136-OUT,B-488-RGB;n:type:ShaderForge.SFN_ValueProperty,id:4136,x:32201,y:32647,ptovrint:False,ptlb:emit power,ptin:_emitpower,varname:node_4136,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Tex2d,id:1106,x:32772,y:33643,ptovrint:False,ptlb:opacity matcap,ptin:_opacitymatcap,varname:_matcaptexture_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:cbc9c6f33cb2bec4d91cd1489a6f36f0,ntxv:0,isnm:False|UVIN-3218-OUT;n:type:ShaderForge.SFN_RemapRange,id:3218,x:32539,y:33754,varname:node_3218,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-2669-OUT;n:type:ShaderForge.SFN_ComponentMask,id:2669,x:32356,y:33754,varname:node_2669,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-3454-XYZ;n:type:ShaderForge.SFN_Transform,id:3454,x:32174,y:33754,varname:node_3454,prsc:2,tffrom:0,tfto:3|IN-9199-OUT;n:type:ShaderForge.SFN_NormalVector,id:9199,x:31987,y:33754,prsc:2,pt:False;n:type:ShaderForge.SFN_Fresnel,id:3593,x:31790,y:33144,varname:node_3593,prsc:2|EXP-4585-OUT;n:type:ShaderForge.SFN_Slider,id:4585,x:31467,y:33144,ptovrint:False,ptlb:refraction power,ptin:_refractionpower,varname:node_4585,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:3;n:type:ShaderForge.SFN_Multiply,id:5482,x:31956,y:33255,varname:node_5482,prsc:2|A-3593-OUT,B-7738-OUT;n:type:ShaderForge.SFN_Slider,id:7738,x:31593,y:33316,ptovrint:False,ptlb:refraction intensity,ptin:_refractionintensity,varname:node_7738,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2,max:3;n:type:ShaderForge.SFN_TexCoord,id:7398,x:32108,y:33304,varname:node_7398,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:4247,x:32485,y:33271,varname:node_4247,prsc:2|A-3788-OUT,B-4153-OUT;n:type:ShaderForge.SFN_Add,id:3788,x:32231,y:33189,varname:node_3788,prsc:2|A-5482-OUT,B-5866-OUT;n:type:ShaderForge.SFN_Slider,id:5866,x:31937,y:33111,ptovrint:False,ptlb:refraction blend,ptin:_refractionblend,varname:node_5866,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2,max:1;n:type:ShaderForge.SFN_Add,id:485,x:32896,y:33816,varname:node_485,prsc:2|A-1106-RGB,B-8057-OUT;n:type:ShaderForge.SFN_ComponentMask,id:9110,x:33098,y:33757,varname:node_9110,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-1106-RGB;n:type:ShaderForge.SFN_NormalVector,id:4153,x:32108,y:33454,prsc:2,pt:False;n:type:ShaderForge.SFN_Fresnel,id:1052,x:32194,y:31724,varname:node_1052,prsc:2|EXP-5984-OUT;n:type:ShaderForge.SFN_Add,id:5508,x:32493,y:31836,varname:node_5508,prsc:2|A-1052-OUT,B-488-RGB;n:type:ShaderForge.SFN_Vector1,id:5984,x:31952,y:31824,varname:node_5984,prsc:2,v1:2;n:type:ShaderForge.SFN_Color,id:4106,x:32463,y:31609,ptovrint:False,ptlb:tint color,ptin:_tintcolor,varname:node_4106,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.6432894,c2:0.8926344,c3:0.9811321,c4:1;n:type:ShaderForge.SFN_Multiply,id:6791,x:32800,y:32285,varname:node_6791,prsc:2|A-4106-RGB,B-5508-OUT;proporder:4918-488-2638-3927-816-721-4136-4585-7738-5866-1106-4106;pass:END;sub:END;*/

Shader "WaterDrop" {
    Properties {
        _opacitypower ("opacity power", Float ) = 0.9
        _matcaptexture ("matcap texture", 2D) = "white" {}
        _opacityintensity ("opacity intensity", Range(0, 1)) = 0.1
        _specular ("specular", Range(0, 2)) = 1.365328
        _transmission ("transmission", Range(0, 1)) = 0.3463756
        _gloss ("gloss", Range(0, 1)) = 0.8
        _emitpower ("emit power", Float ) = 0.5
        _refractionpower ("refraction power", Range(0, 3)) = 1
        _refractionintensity ("refraction intensity", Range(0, 3)) = 2
        _refractionblend ("refraction blend", Range(0, 1)) = 0.2
        _opacitymatcap ("opacity matcap", 2D) = "white" {}
        _tintcolor ("tint color", Color) = (0.6432894,0.8926344,0.9811321,1)
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _GrabTexture;
            uniform sampler2D _matcaptexture; uniform float4 _matcaptexture_ST;
            uniform sampler2D _opacitymatcap; uniform float4 _opacitymatcap_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _specular)
                UNITY_DEFINE_INSTANCED_PROP( float, _transmission)
                UNITY_DEFINE_INSTANCED_PROP( float, _gloss)
                UNITY_DEFINE_INSTANCED_PROP( float, _emitpower)
                UNITY_DEFINE_INSTANCED_PROP( float, _refractionpower)
                UNITY_DEFINE_INSTANCED_PROP( float, _refractionintensity)
                UNITY_DEFINE_INSTANCED_PROP( float, _refractionblend)
                UNITY_DEFINE_INSTANCED_PROP( float4, _tintcolor)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                float4 projPos : TEXCOORD2;
                UNITY_FOG_COORDS(3)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float _refractionpower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _refractionpower );
                float _refractionintensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _refractionintensity );
                float _refractionblend_var = UNITY_ACCESS_INSTANCED_PROP( Props, _refractionblend );
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (((pow(1.0-max(0,dot(normalDirection, viewDirection)),_refractionpower_var)*_refractionintensity_var)+_refractionblend_var)*i.normalDir).rg;
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float _gloss_var = UNITY_ACCESS_INSTANCED_PROP( Props, _gloss );
                float gloss = _gloss_var;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float _specular_var = UNITY_ACCESS_INSTANCED_PROP( Props, _specular );
                float3 specularColor = float3(_specular_var,_specular_var,_specular_var);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = dot( normalDirection, lightDirection );
                float3 forwardLight = max(0.0, NdotL );
                float _transmission_var = UNITY_ACCESS_INSTANCED_PROP( Props, _transmission );
                float3 backLight = max(0.0, -NdotL ) * float3(_transmission_var,_transmission_var,_transmission_var);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = (forwardLight+backLight) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float4 _tintcolor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _tintcolor );
                float2 node_3158 = (mul( UNITY_MATRIX_V, float4(i.normalDir,0) ).xyz.rgb.rg*0.5+0.5);
                float4 _matcaptexture_var = tex2D(_matcaptexture,TRANSFORM_TEX(node_3158, _matcaptexture));
                float3 node_5508 = (pow(1.0-max(0,dot(normalDirection, viewDirection)),2.0)+_matcaptexture_var.rgb);
                float3 diffuseColor = (_tintcolor_var.rgb*node_5508);
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float _emitpower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _emitpower );
                float3 emissive = (_emitpower_var*_matcaptexture_var.rgb);
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                float2 node_3218 = (mul( UNITY_MATRIX_V, float4(i.normalDir,0) ).xyz.rgb.rg*0.5+0.5);
                float4 _opacitymatcap_var = tex2D(_opacitymatcap,TRANSFORM_TEX(node_3218, _opacitymatcap));
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,_opacitymatcap_var.rgb.r),1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _GrabTexture;
            uniform sampler2D _matcaptexture; uniform float4 _matcaptexture_ST;
            uniform sampler2D _opacitymatcap; uniform float4 _opacitymatcap_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _specular)
                UNITY_DEFINE_INSTANCED_PROP( float, _transmission)
                UNITY_DEFINE_INSTANCED_PROP( float, _gloss)
                UNITY_DEFINE_INSTANCED_PROP( float, _emitpower)
                UNITY_DEFINE_INSTANCED_PROP( float, _refractionpower)
                UNITY_DEFINE_INSTANCED_PROP( float, _refractionintensity)
                UNITY_DEFINE_INSTANCED_PROP( float, _refractionblend)
                UNITY_DEFINE_INSTANCED_PROP( float4, _tintcolor)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                float4 projPos : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float _refractionpower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _refractionpower );
                float _refractionintensity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _refractionintensity );
                float _refractionblend_var = UNITY_ACCESS_INSTANCED_PROP( Props, _refractionblend );
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (((pow(1.0-max(0,dot(normalDirection, viewDirection)),_refractionpower_var)*_refractionintensity_var)+_refractionblend_var)*i.normalDir).rg;
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float _gloss_var = UNITY_ACCESS_INSTANCED_PROP( Props, _gloss );
                float gloss = _gloss_var;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float _specular_var = UNITY_ACCESS_INSTANCED_PROP( Props, _specular );
                float3 specularColor = float3(_specular_var,_specular_var,_specular_var);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = dot( normalDirection, lightDirection );
                float3 forwardLight = max(0.0, NdotL );
                float _transmission_var = UNITY_ACCESS_INSTANCED_PROP( Props, _transmission );
                float3 backLight = max(0.0, -NdotL ) * float3(_transmission_var,_transmission_var,_transmission_var);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = (forwardLight+backLight) * attenColor;
                float4 _tintcolor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _tintcolor );
                float2 node_3158 = (mul( UNITY_MATRIX_V, float4(i.normalDir,0) ).xyz.rgb.rg*0.5+0.5);
                float4 _matcaptexture_var = tex2D(_matcaptexture,TRANSFORM_TEX(node_3158, _matcaptexture));
                float3 node_5508 = (pow(1.0-max(0,dot(normalDirection, viewDirection)),2.0)+_matcaptexture_var.rgb);
                float3 diffuseColor = (_tintcolor_var.rgb*node_5508);
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float2 node_3218 = (mul( UNITY_MATRIX_V, float4(i.normalDir,0) ).xyz.rgb.rg*0.5+0.5);
                float4 _opacitymatcap_var = tex2D(_opacitymatcap,TRANSFORM_TEX(node_3218, _opacitymatcap));
                fixed4 finalRGBA = fixed4(finalColor * _opacitymatcap_var.rgb.r,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
