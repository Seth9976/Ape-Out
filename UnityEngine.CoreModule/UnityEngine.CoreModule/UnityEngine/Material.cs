using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000072 RID: 114
	public class Material : Object
	{
		// Token: 0x060009C4 RID: 2500 RVA: 0x0002C04C File Offset: 0x0002A24C
		// Note: this type is marked as 'beforefieldinit'.
		static Material()
		{
			Il2CppClassPointerStore<Material>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Material");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Material>.NativeClassPtr);
			Material.NativeMethodInfoPtr_CreateWithShader_Private_Static_Void_Material_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663923);
			Material.NativeMethodInfoPtr_CreateWithMaterial_Private_Static_Void_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663924);
			Material.NativeMethodInfoPtr_CreateWithString_Private_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663925);
			Material.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663926);
			Material.NativeMethodInfoPtr__ctor_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663927);
			Material.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663928);
			Material.NativeMethodInfoPtr_set_shader_Public_set_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663929);
			Material.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663930);
			Material.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663931);
			Material.NativeMethodInfoPtr_get_mainTexture_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663932);
			Material.NativeMethodInfoPtr_set_mainTexture_Public_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663933);
			Material.NativeMethodInfoPtr_get_mainTextureOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663934);
			Material.NativeMethodInfoPtr_set_mainTextureOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663935);
			Material.NativeMethodInfoPtr_get_mainTextureScale_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663936);
			Material.NativeMethodInfoPtr_set_mainTextureScale_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663937);
			Material.NativeMethodInfoPtr_GetFirstPropertyNameIdByAttribute_Private_Int32_ShaderPropertyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663938);
			Material.NativeMethodInfoPtr_HasProperty_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663939);
			Material.NativeMethodInfoPtr_HasProperty_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663940);
			Material.NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663941);
			Material.NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663942);
			Material.NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663943);
			Material.NativeMethodInfoPtr_get_passCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663944);
			Material.NativeMethodInfoPtr_CopyPropertiesFromMaterial_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663945);
			Material.NativeMethodInfoPtr_GetShaderKeywords_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663946);
			Material.NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663947);
			Material.NativeMethodInfoPtr_get_shaderKeywords_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663948);
			Material.NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663949);
			Material.NativeMethodInfoPtr_ComputeCRC_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663950);
			Material.NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663951);
			Material.NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663952);
			Material.NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663953);
			Material.NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663954);
			Material.NativeMethodInfoPtr_GetFloatImpl_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663955);
			Material.NativeMethodInfoPtr_GetColorImpl_Private_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663956);
			Material.NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663957);
			Material.NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663958);
			Material.NativeMethodInfoPtr_GetFloatArrayImpl_Private_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663959);
			Material.NativeMethodInfoPtr_GetFloatArrayCountImpl_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663960);
			Material.NativeMethodInfoPtr_GetTextureScaleAndOffsetImpl_Private_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663961);
			Material.NativeMethodInfoPtr_SetTextureOffsetImpl_Private_Void_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663962);
			Material.NativeMethodInfoPtr_SetTextureScaleImpl_Private_Void_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663963);
			Material.NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663964);
			Material.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663965);
			Material.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663966);
			Material.NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663967);
			Material.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663968);
			Material.NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663969);
			Material.NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663970);
			Material.NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663971);
			Material.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663972);
			Material.NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663973);
			Material.NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663974);
			Material.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663975);
			Material.NativeMethodInfoPtr_SetFloatArray_Public_Void_String_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663976);
			Material.NativeMethodInfoPtr_GetFloat_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663977);
			Material.NativeMethodInfoPtr_GetFloat_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663978);
			Material.NativeMethodInfoPtr_GetColor_Public_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663979);
			Material.NativeMethodInfoPtr_GetColor_Public_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663980);
			Material.NativeMethodInfoPtr_GetVector_Public_Vector4_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663981);
			Material.NativeMethodInfoPtr_GetVector_Public_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663982);
			Material.NativeMethodInfoPtr_GetTexture_Public_Texture_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663983);
			Material.NativeMethodInfoPtr_GetTexture_Public_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663984);
			Material.NativeMethodInfoPtr_GetFloatArray_Public_Il2CppStructArray_1_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663985);
			Material.NativeMethodInfoPtr_GetFloatArray_Public_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663986);
			Material.NativeMethodInfoPtr_SetTextureOffset_Public_Void_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663987);
			Material.NativeMethodInfoPtr_SetTextureOffset_Public_Void_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663988);
			Material.NativeMethodInfoPtr_SetTextureScale_Public_Void_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663989);
			Material.NativeMethodInfoPtr_SetTextureScale_Public_Void_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663990);
			Material.NativeMethodInfoPtr_GetTextureOffset_Public_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663991);
			Material.NativeMethodInfoPtr_GetTextureOffset_Public_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663992);
			Material.NativeMethodInfoPtr_GetTextureScale_Public_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663993);
			Material.NativeMethodInfoPtr_GetTextureScale_Public_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663994);
			Material.NativeMethodInfoPtr_SetColorImpl_Injected_Private_Void_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663995);
			Material.NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663996);
			Material.NativeMethodInfoPtr_GetColorImpl_Injected_Private_Void_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663997);
			Material.NativeMethodInfoPtr_GetTextureScaleAndOffsetImpl_Injected_Private_Void_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663998);
			Material.NativeMethodInfoPtr_SetTextureOffsetImpl_Injected_Private_Void_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100663999);
			Material.NativeMethodInfoPtr_SetTextureScaleImpl_Injected_Private_Void_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664000);
			Material.GetDefaultMaterialDelegateField = IL2CPP.ResolveICall<Material.GetDefaultMaterialDelegate>("UnityEngine.Material::GetDefaultMaterial");
			Material.GetDefaultParticleMaterialDelegateField = IL2CPP.ResolveICall<Material.GetDefaultParticleMaterialDelegate>("UnityEngine.Material::GetDefaultParticleMaterial");
			Material.GetDefaultLineMaterialDelegateField = IL2CPP.ResolveICall<Material.GetDefaultLineMaterialDelegate>("UnityEngine.Material::GetDefaultLineMaterial");
			Material.get_shaderDelegateField = IL2CPP.ResolveICall<Material.get_shaderDelegate>("UnityEngine.Material::get_shader");
			Material.get_renderQueueDelegateField = IL2CPP.ResolveICall<Material.get_renderQueueDelegate>("UnityEngine.Material::get_renderQueue");
			Material.get_rawRenderQueueDelegateField = IL2CPP.ResolveICall<Material.get_rawRenderQueueDelegate>("UnityEngine.Material::get_rawRenderQueue");
			Material.IsKeywordEnabledDelegateField = IL2CPP.ResolveICall<Material.IsKeywordEnabledDelegate>("UnityEngine.Material::IsKeywordEnabled");
			Material.get_globalIlluminationFlagsDelegateField = IL2CPP.ResolveICall<Material.get_globalIlluminationFlagsDelegate>("UnityEngine.Material::get_globalIlluminationFlags");
			Material.set_globalIlluminationFlagsDelegateField = IL2CPP.ResolveICall<Material.set_globalIlluminationFlagsDelegate>("UnityEngine.Material::set_globalIlluminationFlags");
			Material.get_doubleSidedGIDelegateField = IL2CPP.ResolveICall<Material.get_doubleSidedGIDelegate>("UnityEngine.Material::get_doubleSidedGI");
			Material.set_doubleSidedGIDelegateField = IL2CPP.ResolveICall<Material.set_doubleSidedGIDelegate>("UnityEngine.Material::set_doubleSidedGI");
			Material.get_enableInstancingDelegateField = IL2CPP.ResolveICall<Material.get_enableInstancingDelegate>("UnityEngine.Material::get_enableInstancing");
			Material.set_enableInstancingDelegateField = IL2CPP.ResolveICall<Material.set_enableInstancingDelegate>("UnityEngine.Material::set_enableInstancing");
			Material.SetShaderPassEnabledDelegateField = IL2CPP.ResolveICall<Material.SetShaderPassEnabledDelegate>("UnityEngine.Material::SetShaderPassEnabled");
			Material.GetShaderPassEnabledDelegateField = IL2CPP.ResolveICall<Material.GetShaderPassEnabledDelegate>("UnityEngine.Material::GetShaderPassEnabled");
			Material.GetPassNameDelegateField = IL2CPP.ResolveICall<Material.GetPassNameDelegate>("UnityEngine.Material::GetPassName");
			Material.FindPassDelegateField = IL2CPP.ResolveICall<Material.FindPassDelegate>("UnityEngine.Material::FindPass");
			Material.SetOverrideTagDelegateField = IL2CPP.ResolveICall<Material.SetOverrideTagDelegate>("UnityEngine.Material::SetOverrideTag");
			Material.GetTagImplDelegateField = IL2CPP.ResolveICall<Material.GetTagImplDelegate>("UnityEngine.Material::GetTagImpl");
			Material.LerpDelegateField = IL2CPP.ResolveICall<Material.LerpDelegate>("UnityEngine.Material::Lerp");
			Material.SetPassDelegateField = IL2CPP.ResolveICall<Material.SetPassDelegate>("UnityEngine.Material::SetPass");
			Material.GetTexturePropertyNamesDelegateField = IL2CPP.ResolveICall<Material.GetTexturePropertyNamesDelegate>("UnityEngine.Material::GetTexturePropertyNames");
			Material.GetTexturePropertyNameIDsDelegateField = IL2CPP.ResolveICall<Material.GetTexturePropertyNameIDsDelegate>("UnityEngine.Material::GetTexturePropertyNameIDs");
			Material.GetTexturePropertyNamesInternalDelegateField = IL2CPP.ResolveICall<Material.GetTexturePropertyNamesInternalDelegate>("UnityEngine.Material::GetTexturePropertyNamesInternal");
			Material.GetTexturePropertyNameIDsInternalDelegateField = IL2CPP.ResolveICall<Material.GetTexturePropertyNameIDsInternalDelegate>("UnityEngine.Material::GetTexturePropertyNameIDsInternal");
			Material.SetRenderTextureImplDelegateField = IL2CPP.ResolveICall<Material.SetRenderTextureImplDelegate>("UnityEngine.Material::SetRenderTextureImpl");
			Material.SetBufferImplDelegateField = IL2CPP.ResolveICall<Material.SetBufferImplDelegate>("UnityEngine.Material::SetBufferImpl");
			Material.SetGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<Material.SetGraphicsBufferImplDelegate>("UnityEngine.Material::SetGraphicsBufferImpl");
			Material.SetConstantBufferImplDelegateField = IL2CPP.ResolveICall<Material.SetConstantBufferImplDelegate>("UnityEngine.Material::SetConstantBufferImpl");
			Material.SetConstantGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<Material.SetConstantGraphicsBufferImplDelegate>("UnityEngine.Material::SetConstantGraphicsBufferImpl");
			Material.SetVectorArrayImplDelegateField = IL2CPP.ResolveICall<Material.SetVectorArrayImplDelegate>("UnityEngine.Material::SetVectorArrayImpl");
			Material.SetColorArrayImplDelegateField = IL2CPP.ResolveICall<Material.SetColorArrayImplDelegate>("UnityEngine.Material::SetColorArrayImpl");
			Material.SetMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Material.SetMatrixArrayImplDelegate>("UnityEngine.Material::SetMatrixArrayImpl");
			Material.GetVectorArrayImplDelegateField = IL2CPP.ResolveICall<Material.GetVectorArrayImplDelegate>("UnityEngine.Material::GetVectorArrayImpl");
			Material.GetColorArrayImplDelegateField = IL2CPP.ResolveICall<Material.GetColorArrayImplDelegate>("UnityEngine.Material::GetColorArrayImpl");
			Material.GetMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Material.GetMatrixArrayImplDelegate>("UnityEngine.Material::GetMatrixArrayImpl");
			Material.GetVectorArrayCountImplDelegateField = IL2CPP.ResolveICall<Material.GetVectorArrayCountImplDelegate>("UnityEngine.Material::GetVectorArrayCountImpl");
			Material.GetColorArrayCountImplDelegateField = IL2CPP.ResolveICall<Material.GetColorArrayCountImplDelegate>("UnityEngine.Material::GetColorArrayCountImpl");
			Material.GetMatrixArrayCountImplDelegateField = IL2CPP.ResolveICall<Material.GetMatrixArrayCountImplDelegate>("UnityEngine.Material::GetMatrixArrayCountImpl");
			Material.ExtractFloatArrayImplDelegateField = IL2CPP.ResolveICall<Material.ExtractFloatArrayImplDelegate>("UnityEngine.Material::ExtractFloatArrayImpl");
			Material.ExtractVectorArrayImplDelegateField = IL2CPP.ResolveICall<Material.ExtractVectorArrayImplDelegate>("UnityEngine.Material::ExtractVectorArrayImpl");
			Material.ExtractColorArrayImplDelegateField = IL2CPP.ResolveICall<Material.ExtractColorArrayImplDelegate>("UnityEngine.Material::ExtractColorArrayImpl");
			Material.ExtractMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Material.ExtractMatrixArrayImplDelegate>("UnityEngine.Material::ExtractMatrixArrayImpl");
			Material.GetMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<Material.GetMatrixImpl_InjectedDelegate>("UnityEngine.Material::GetMatrixImpl_Injected");
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0002C928 File Offset: 0x0002AB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488702, XrefRangeEnd = 488706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateWithShader(Material self, Shader shader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_CreateWithShader_Private_Static_Void_Material_Shader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0002C970 File Offset: 0x0002AB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488706, XrefRangeEnd = 488710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateWithMaterial(Material self, Material source)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_CreateWithMaterial_Private_Static_Void_Material_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0002C9B8 File Offset: 0x0002ABB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488710, XrefRangeEnd = 488714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateWithString(Material self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_CreateWithString_Private_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 488721, RefRangeEnd = 488728, XrefRangeStart = 488714, XrefRangeEnd = 488721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material(Shader shader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Material>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0002CA3C File Offset: 0x0002AC3C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 488735, RefRangeEnd = 488748, XrefRangeStart = 488728, XrefRangeEnd = 488735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material(Material source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Material>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr__ctor_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0002CA88 File Offset: 0x0002AC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488748, XrefRangeEnd = 488755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material(string contents)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Material>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0002E060 File Offset: 0x0002C260
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x0002CAD4 File Offset: 0x0002ACD4
		public unsafe Shader shader
		{
			get
			{
				IntPtr intPtr = Material.get_shaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488755, XrefRangeEnd = 488759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_shader_Public_set_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x0002CB18 File Offset: 0x0002AD18
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x0002CB54 File Offset: 0x0002AD54
		public unsafe Color color
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 488767, RefRangeEnd = 488771, XrefRangeStart = 488759, XrefRangeEnd = 488767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 488776, RefRangeEnd = 488800, XrefRangeStart = 488771, XrefRangeEnd = 488776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0002CB94 File Offset: 0x0002AD94
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x0002CBD4 File Offset: 0x0002ADD4
		public unsafe Texture mainTexture
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 488807, RefRangeEnd = 488812, XrefRangeStart = 488800, XrefRangeEnd = 488807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_mainTexture_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 488818, RefRangeEnd = 488824, XrefRangeStart = 488812, XrefRangeEnd = 488818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_mainTexture_Public_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0002CC18 File Offset: 0x0002AE18
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x0002CC54 File Offset: 0x0002AE54
		public unsafe Vector2 mainTextureOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488824, XrefRangeEnd = 488829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_mainTextureOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488829, XrefRangeEnd = 488834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_mainTextureOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0002CC94 File Offset: 0x0002AE94
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x0002CCD0 File Offset: 0x0002AED0
		public unsafe Vector2 mainTextureScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488834, XrefRangeEnd = 488839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_mainTextureScale_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488839, XrefRangeEnd = 488844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_mainTextureScale_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0002CD10 File Offset: 0x0002AF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488844, XrefRangeEnd = 488848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags attributeFlag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attributeFlag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFirstPropertyNameIdByAttribute_Private_Int32_ShaderPropertyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0002CD5C File Offset: 0x0002AF5C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 488852, RefRangeEnd = 488877, XrefRangeStart = 488848, XrefRangeEnd = 488852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasProperty(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_HasProperty_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0002CDA8 File Offset: 0x0002AFA8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 488885, RefRangeEnd = 488900, XrefRangeStart = 488877, XrefRangeEnd = 488885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_HasProperty_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0000758E File Offset: 0x0000578E
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x0002CDF8 File Offset: 0x0002AFF8
		public unsafe int renderQueue
		{
			get
			{
				return Material.get_renderQueueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488900, XrefRangeEnd = 488904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0002CE38 File Offset: 0x0002B038
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488908, RefRangeEnd = 488910, XrefRangeStart = 488904, XrefRangeEnd = 488908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0002CE7C File Offset: 0x0002B07C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 488914, RefRangeEnd = 488917, XrefRangeStart = 488910, XrefRangeEnd = 488914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x0002CEC0 File Offset: 0x0002B0C0
		public unsafe int passCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488917, XrefRangeEnd = 488921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_passCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0002CEFC File Offset: 0x0002B0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488921, XrefRangeEnd = 488925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyPropertiesFromMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_CopyPropertiesFromMaterial_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0002CF40 File Offset: 0x0002B140
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 488929, RefRangeEnd = 488932, XrefRangeStart = 488925, XrefRangeEnd = 488929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetShaderKeywords()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetShaderKeywords_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0002CF80 File Offset: 0x0002B180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488936, RefRangeEnd = 488937, XrefRangeStart = 488932, XrefRangeEnd = 488936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShaderKeywords(Il2CppStringArray names)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(names);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0002CFC4 File Offset: 0x0002B1C4
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x0002D004 File Offset: 0x0002B204
		public unsafe Il2CppStringArray shaderKeywords
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 488929, RefRangeEnd = 488932, XrefRangeStart = 488929, XrefRangeEnd = 488932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_shaderKeywords_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 488936, RefRangeEnd = 488937, XrefRangeStart = 488936, XrefRangeEnd = 488937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0002D048 File Offset: 0x0002B248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488937, XrefRangeEnd = 488941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ComputeCRC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_ComputeCRC_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0002D084 File Offset: 0x0002B284
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 488945, RefRangeEnd = 488965, XrefRangeStart = 488941, XrefRangeEnd = 488945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatImpl(int name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0002D0D0 File Offset: 0x0002B2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488965, XrefRangeEnd = 488967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColorImpl(int name, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0002D11C File Offset: 0x0002B31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488967, XrefRangeEnd = 488969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixImpl(int name, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0002D168 File Offset: 0x0002B368
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 488973, RefRangeEnd = 488983, XrefRangeStart = 488969, XrefRangeEnd = 488973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureImpl(int name, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0002D1B8 File Offset: 0x0002B3B8
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 488987, RefRangeEnd = 489044, XrefRangeStart = 488983, XrefRangeEnd = 488987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFloatImpl(int name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFloatImpl_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0002D204 File Offset: 0x0002B404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489044, XrefRangeEnd = 489046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetColorImpl(int name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetColorImpl_Private_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0002D250 File Offset: 0x0002B450
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 489050, RefRangeEnd = 489065, XrefRangeStart = 489046, XrefRangeEnd = 489050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture GetTextureImpl(int name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0002D29C File Offset: 0x0002B49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489065, XrefRangeEnd = 489069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatArrayImpl(int name, Il2CppStructArray<float> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0002D2FC File Offset: 0x0002B4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489069, XrefRangeEnd = 489073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<float> GetFloatArrayImpl(int name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFloatArrayImpl_Private_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0002D348 File Offset: 0x0002B548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489073, XrefRangeEnd = 489077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFloatArrayCountImpl(int name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFloatArrayCountImpl_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0002D394 File Offset: 0x0002B594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489077, XrefRangeEnd = 489079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetTextureScaleAndOffsetImpl(int name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTextureScaleAndOffsetImpl_Private_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0002D3E0 File Offset: 0x0002B5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489079, XrefRangeEnd = 489081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureOffsetImpl(int name, Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTextureOffsetImpl_Private_Void_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0002D42C File Offset: 0x0002B62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489081, XrefRangeEnd = 489083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureScaleImpl(int name, Vector2 scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTextureScaleImpl_Private_Void_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0002D478 File Offset: 0x0002B678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489083, XrefRangeEnd = 489105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatArray(int name, Il2CppStructArray<float> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0002D4D8 File Offset: 0x0002B6D8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 489113, RefRangeEnd = 489133, XrefRangeStart = 489105, XrefRangeEnd = 489113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloat(string name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0002D528 File Offset: 0x0002B728
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 488945, RefRangeEnd = 488965, XrefRangeStart = 488945, XrefRangeEnd = 488965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloat(int nameID, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0002D574 File Offset: 0x0002B774
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 489141, RefRangeEnd = 489149, XrefRangeStart = 489133, XrefRangeEnd = 489141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInt(string name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0002D5C4 File Offset: 0x0002B7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489149, XrefRangeEnd = 489153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInt(int nameID, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0002D610 File Offset: 0x0002B810
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 489157, RefRangeEnd = 489162, XrefRangeStart = 489153, XrefRangeEnd = 489157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(string name, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0002D660 File Offset: 0x0002B860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489162, XrefRangeEnd = 489164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(int nameID, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0002D6AC File Offset: 0x0002B8AC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 489168, RefRangeEnd = 489183, XrefRangeStart = 489164, XrefRangeEnd = 489168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVector(string name, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0002D6FC File Offset: 0x0002B8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489183, XrefRangeEnd = 489185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVector(int nameID, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0002D748 File Offset: 0x0002B948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489185, XrefRangeEnd = 489187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrix(int nameID, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0002D794 File Offset: 0x0002B994
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 489195, RefRangeEnd = 489236, XrefRangeStart = 489187, XrefRangeEnd = 489195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(string name, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0002D7E8 File Offset: 0x0002B9E8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 488973, RefRangeEnd = 488983, XrefRangeStart = 488973, XrefRangeEnd = 488983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(int nameID, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0002D838 File Offset: 0x0002BA38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489251, RefRangeEnd = 489253, XrefRangeStart = 489236, XrefRangeEnd = 489251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatArray(string name, Il2CppStructArray<float> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetFloatArray_Public_Void_String_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0002D88C File Offset: 0x0002BA8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 489261, RefRangeEnd = 489264, XrefRangeStart = 489253, XrefRangeEnd = 489261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFloat(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFloat_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0002D8DC File Offset: 0x0002BADC
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 488987, RefRangeEnd = 489044, XrefRangeStart = 488987, XrefRangeEnd = 489044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFloat(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFloat_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0002D928 File Offset: 0x0002BB28
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 489268, RefRangeEnd = 489273, XrefRangeStart = 489264, XrefRangeEnd = 489268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetColor(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetColor_Public_Color_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0002D978 File Offset: 0x0002BB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489273, XrefRangeEnd = 489275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetColor(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetColor_Public_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0002D9C4 File Offset: 0x0002BBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489275, XrefRangeEnd = 489279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetVector(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetVector_Public_Vector4_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0002DA14 File Offset: 0x0002BC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489279, XrefRangeEnd = 489281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetVector(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetVector_Public_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0002DA60 File Offset: 0x0002BC60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 489289, RefRangeEnd = 489293, XrefRangeStart = 489281, XrefRangeEnd = 489289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture GetTexture(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTexture_Public_Texture_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0002DAB0 File Offset: 0x0002BCB0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 489050, RefRangeEnd = 489065, XrefRangeStart = 489050, XrefRangeEnd = 489065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture GetTexture(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTexture_Public_Texture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0002DAFC File Offset: 0x0002BCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489293, XrefRangeEnd = 489299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<float> GetFloatArray(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFloatArray_Public_Il2CppStructArray_1_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0002DB4C File Offset: 0x0002BD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489299, XrefRangeEnd = 489303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<float> GetFloatArray(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFloatArray_Public_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0002DB98 File Offset: 0x0002BD98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 489307, RefRangeEnd = 489310, XrefRangeStart = 489303, XrefRangeEnd = 489307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureOffset(string name, Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTextureOffset_Public_Void_String_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0002DBE8 File Offset: 0x0002BDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureOffset(int nameID, Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTextureOffset_Public_Void_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0002DC34 File Offset: 0x0002BE34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 489314, RefRangeEnd = 489317, XrefRangeStart = 489310, XrefRangeEnd = 489314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureScale(string name, Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTextureScale_Public_Void_String_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0002DC84 File Offset: 0x0002BE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureScale(int nameID, Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTextureScale_Public_Void_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0002DCD0 File Offset: 0x0002BED0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 489320, RefRangeEnd = 489323, XrefRangeStart = 489317, XrefRangeEnd = 489320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetTextureOffset(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTextureOffset_Public_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x0002DD20 File Offset: 0x0002BF20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489325, RefRangeEnd = 489327, XrefRangeStart = 489323, XrefRangeEnd = 489325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetTextureOffset(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTextureOffset_Public_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0002DD6C File Offset: 0x0002BF6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 489330, RefRangeEnd = 489333, XrefRangeStart = 489327, XrefRangeEnd = 489330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetTextureScale(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTextureScale_Public_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0002DDBC File Offset: 0x0002BFBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489335, RefRangeEnd = 489337, XrefRangeStart = 489333, XrefRangeEnd = 489335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetTextureScale(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTextureScale_Public_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0002DE08 File Offset: 0x0002C008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489337, XrefRangeEnd = 489341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColorImpl_Injected(int name, ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetColorImpl_Injected_Private_Void_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0002DE54 File Offset: 0x0002C054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489341, XrefRangeEnd = 489345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixImpl_Injected(int name, ref Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0002DEA0 File Offset: 0x0002C0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489345, XrefRangeEnd = 489349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetColorImpl_Injected(int name, out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetColorImpl_Injected_Private_Void_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0002DEEC File Offset: 0x0002C0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489349, XrefRangeEnd = 489353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTextureScaleAndOffsetImpl_Injected_Private_Void_Int32_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x0002DF38 File Offset: 0x0002C138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489353, XrefRangeEnd = 489357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTextureOffsetImpl_Injected_Private_Void_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0002DF84 File Offset: 0x0002C184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489357, XrefRangeEnd = 489361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureScaleImpl_Injected(int name, ref Vector2 scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTextureScaleImpl_Injected_Private_Void_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00007585 File Offset: 0x00005785
		public Material(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0002DFD0 File Offset: 0x0002C1D0
		public static Material Create(string scriptContents)
		{
			return new Material(scriptContents);
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0002DFE8 File Offset: 0x0002C1E8
		public static Material GetDefaultMaterial()
		{
			IntPtr intPtr = Material.GetDefaultMaterialDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0002E010 File Offset: 0x0002C210
		public static Material GetDefaultParticleMaterial()
		{
			IntPtr intPtr = Material.GetDefaultParticleMaterialDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0002E038 File Offset: 0x0002C238
		public static Material GetDefaultLineMaterial()
		{
			IntPtr intPtr = Material.GetDefaultLineMaterialDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x000075A0 File Offset: 0x000057A0
		public int rawRenderQueue
		{
			get
			{
				return Material.get_rawRenderQueueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000075B2 File Offset: 0x000057B2
		public bool IsKeywordEnabled(string keyword)
		{
			return Material.IsKeywordEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x000075CA File Offset: 0x000057CA
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x000075DC File Offset: 0x000057DC
		public MaterialGlobalIlluminationFlags globalIlluminationFlags
		{
			get
			{
				return Material.get_globalIlluminationFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Material.set_globalIlluminationFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x000075EF File Offset: 0x000057EF
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00007601 File Offset: 0x00005801
		public bool doubleSidedGI
		{
			get
			{
				return Material.get_doubleSidedGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Material.set_doubleSidedGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00007614 File Offset: 0x00005814
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00007626 File Offset: 0x00005826
		public bool enableInstancing
		{
			get
			{
				return Material.get_enableInstancingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Material.set_enableInstancingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00007639 File Offset: 0x00005839
		public void SetShaderPassEnabled(string passName, bool enabled)
		{
			Material.SetShaderPassEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(passName), enabled);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00007652 File Offset: 0x00005852
		public bool GetShaderPassEnabled(string passName)
		{
			return Material.GetShaderPassEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(passName));
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0002E08C File Offset: 0x0002C28C
		public string GetPassName(int pass)
		{
			IntPtr intPtr = Material.GetPassNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), pass);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0000766A File Offset: 0x0000586A
		public int FindPass(string passName)
		{
			return Material.FindPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(passName));
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00007682 File Offset: 0x00005882
		public void SetOverrideTag(string tag, string val)
		{
			Material.SetOverrideTagDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(tag), IL2CPP.ManagedStringToIl2Cpp(val));
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0002E0B4 File Offset: 0x0002C2B4
		public string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue)
		{
			IntPtr intPtr = Material.GetTagImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(tag), currentSubShaderOnly, IL2CPP.ManagedStringToIl2Cpp(defaultValue));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0002E0E8 File Offset: 0x0002C2E8
		public string GetTag(string tag, bool searchFallbacks, string defaultValue)
		{
			return this.GetTagImpl(tag, !searchFallbacks, defaultValue);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0002E108 File Offset: 0x0002C308
		public string GetTag(string tag, bool searchFallbacks)
		{
			return this.GetTagImpl(tag, !searchFallbacks, "");
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000076A0 File Offset: 0x000058A0
		public void Lerp(Material start, Material end, float t)
		{
			Material.LerpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(start), IL2CPP.Il2CppObjectBaseToPtr(end), t);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x000076BF File Offset: 0x000058BF
		public bool SetPass(int pass)
		{
			return Material.SetPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), pass);
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0002E12C File Offset: 0x0002C32C
		public Il2CppStringArray GetTexturePropertyNames()
		{
			IntPtr intPtr = Material.GetTexturePropertyNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0002E158 File Offset: 0x0002C358
		public Il2CppStructArray<int> GetTexturePropertyNameIDs()
		{
			IntPtr intPtr = Material.GetTexturePropertyNameIDsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000076D2 File Offset: 0x000058D2
		public void GetTexturePropertyNamesInternal(Object outNames)
		{
			Material.GetTexturePropertyNamesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(outNames));
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x000076EA File Offset: 0x000058EA
		public void GetTexturePropertyNameIDsInternal(Object outNames)
		{
			Material.GetTexturePropertyNameIDsInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(outNames));
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0002E184 File Offset: 0x0002C384
		public void GetTexturePropertyNames(List<string> outNames)
		{
			bool flag = outNames == null;
			if (flag)
			{
				throw new ArgumentNullException("outNames");
			}
			this.GetTexturePropertyNamesInternal(outNames);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0002E1B0 File Offset: 0x0002C3B0
		public void GetTexturePropertyNameIDs(List<int> outNames)
		{
			bool flag = outNames == null;
			if (flag)
			{
				throw new ArgumentNullException("outNames");
			}
			this.GetTexturePropertyNameIDsInternal(outNames);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00007702 File Offset: 0x00005902
		public void SetRenderTextureImpl(int name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			Material.SetRenderTextureImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), element);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0000771C File Offset: 0x0000591C
		public void SetBufferImpl(int name, ComputeBuffer value)
		{
			Material.SetBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00007735 File Offset: 0x00005935
		public void SetGraphicsBufferImpl(int name, GraphicsBuffer value)
		{
			Material.SetGraphicsBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0000774E File Offset: 0x0000594E
		public void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
		{
			Material.SetConstantBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0000776A File Offset: 0x0000596A
		public void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size)
		{
			Material.SetConstantGraphicsBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0002E1DC File Offset: 0x0002C3DC
		public Matrix4x4 GetMatrixImpl(int name)
		{
			Matrix4x4 matrix4x;
			this.GetMatrixImpl_Injected(name, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00007786 File Offset: 0x00005986
		public void SetVectorArrayImpl(int name, Il2CppStructArray<Vector4> values, int count)
		{
			Material.SetVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x000077A0 File Offset: 0x000059A0
		public void SetColorArrayImpl(int name, Il2CppStructArray<Color> values, int count)
		{
			Material.SetColorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x000077BA File Offset: 0x000059BA
		public void SetMatrixArrayImpl(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			Material.SetMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0002E1F4 File Offset: 0x0002C3F4
		public Il2CppStructArray<Vector4> GetVectorArrayImpl(int name)
		{
			IntPtr intPtr = Material.GetVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0002E224 File Offset: 0x0002C424
		public Il2CppStructArray<Color> GetColorArrayImpl(int name)
		{
			IntPtr intPtr = Material.GetColorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0002E254 File Offset: 0x0002C454
		public Il2CppStructArray<Matrix4x4> GetMatrixArrayImpl(int name)
		{
			IntPtr intPtr = Material.GetMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x000077D4 File Offset: 0x000059D4
		public int GetVectorArrayCountImpl(int name)
		{
			return Material.GetVectorArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x000077E7 File Offset: 0x000059E7
		public int GetColorArrayCountImpl(int name)
		{
			return Material.GetColorArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000077FA File Offset: 0x000059FA
		public int GetMatrixArrayCountImpl(int name)
		{
			return Material.GetMatrixArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0000780D File Offset: 0x00005A0D
		public void ExtractFloatArrayImpl(int name, [Out] Il2CppStructArray<float> val)
		{
			Material.ExtractFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00007826 File Offset: 0x00005A26
		public void ExtractVectorArrayImpl(int name, [Out] Il2CppStructArray<Vector4> val)
		{
			Material.ExtractVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0000783F File Offset: 0x00005A3F
		public void ExtractColorArrayImpl(int name, [Out] Il2CppStructArray<Color> val)
		{
			Material.ExtractColorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00007858 File Offset: 0x00005A58
		public void ExtractMatrixArrayImpl(int name, [Out] Il2CppStructArray<Matrix4x4> val)
		{
			Material.ExtractMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0002E284 File Offset: 0x0002C484
		public void SetVectorArray(int name, Il2CppStructArray<Vector4> values, int count)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			bool flag3 = values.Length < count;
			if (flag3)
			{
				throw new ArgumentException("array has less elements than passed count.");
			}
			this.SetVectorArrayImpl(name, values, count);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0002E2E0 File Offset: 0x0002C4E0
		public void SetColorArray(int name, Il2CppStructArray<Color> values, int count)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			bool flag3 = values.Length < count;
			if (flag3)
			{
				throw new ArgumentException("array has less elements than passed count.");
			}
			this.SetColorArrayImpl(name, values, count);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0002E33C File Offset: 0x0002C53C
		public void SetMatrixArray(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			bool flag3 = values.Length < count;
			if (flag3)
			{
				throw new ArgumentException("array has less elements than passed count.");
			}
			this.SetMatrixArrayImpl(name, values, count);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0002E398 File Offset: 0x0002C598
		public void ExtractFloatArray(int name, List<float> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int floatArrayCountImpl = this.GetFloatArrayCountImpl(name);
			bool flag2 = floatArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<float>(values, floatArrayCountImpl);
				this.ExtractFloatArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<float>>());
			}
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0002E3F0 File Offset: 0x0002C5F0
		public void ExtractVectorArray(int name, List<Vector4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int vectorArrayCountImpl = this.GetVectorArrayCountImpl(name);
			bool flag2 = vectorArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Vector4>(values, vectorArrayCountImpl);
				this.ExtractVectorArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Vector4>>());
			}
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0002E448 File Offset: 0x0002C648
		public void ExtractColorArray(int name, List<Color> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int colorArrayCountImpl = this.GetColorArrayCountImpl(name);
			bool flag2 = colorArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Color>(values, colorArrayCountImpl);
				this.ExtractColorArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Color>>());
			}
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0002E4A0 File Offset: 0x0002C6A0
		public void ExtractMatrixArray(int name, List<Matrix4x4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int matrixArrayCountImpl = this.GetMatrixArrayCountImpl(name);
			bool flag2 = matrixArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Matrix4x4>(values, matrixArrayCountImpl);
				this.ExtractMatrixArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Matrix4x4>>());
			}
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00007871 File Offset: 0x00005A71
		public void SetMatrix(string name, Matrix4x4 value)
		{
			this.SetMatrixImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00007882 File Offset: 0x00005A82
		public void SetTexture(string name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTextureImpl(Shader.PropertyToID(name), value, element);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00007894 File Offset: 0x00005A94
		public void SetTexture(int nameID, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTextureImpl(nameID, value, element);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x000078A1 File Offset: 0x00005AA1
		public void SetBuffer(string name, ComputeBuffer value)
		{
			this.SetBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x000078B2 File Offset: 0x00005AB2
		public void SetBuffer(int nameID, ComputeBuffer value)
		{
			this.SetBufferImpl(nameID, value);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x000078BE File Offset: 0x00005ABE
		public void SetBuffer(string name, GraphicsBuffer value)
		{
			this.SetGraphicsBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x000078CF File Offset: 0x00005ACF
		public void SetBuffer(int nameID, GraphicsBuffer value)
		{
			this.SetGraphicsBufferImpl(nameID, value);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x000078DB File Offset: 0x00005ADB
		public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size)
		{
			this.SetConstantBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x000078EF File Offset: 0x00005AEF
		public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
		{
			this.SetConstantBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x000078FE File Offset: 0x00005AFE
		public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size)
		{
			this.SetConstantGraphicsBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00007912 File Offset: 0x00005B12
		public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size)
		{
			this.SetConstantGraphicsBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00007921 File Offset: 0x00005B21
		public void SetFloatArray(string name, List<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0000793D File Offset: 0x00005B3D
		public void SetFloatArray(int nameID, List<float> values)
		{
			this.SetFloatArray(nameID, NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00007954 File Offset: 0x00005B54
		public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(nameID, values, values.Length);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00007967 File Offset: 0x00005B67
		public void SetColorArray(string name, List<Color> values)
		{
			this.SetColorArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Color>(values), values.Count);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00007983 File Offset: 0x00005B83
		public void SetColorArray(int nameID, List<Color> values)
		{
			this.SetColorArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Color>(values), values.Count);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0000799A File Offset: 0x00005B9A
		public void SetColorArray(string name, Il2CppStructArray<Color> values)
		{
			this.SetColorArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x000079B2 File Offset: 0x00005BB2
		public void SetColorArray(int nameID, Il2CppStructArray<Color> values)
		{
			this.SetColorArray(nameID, values, values.Length);
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x000079C5 File Offset: 0x00005BC5
		public void SetVectorArray(string name, List<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x000079E1 File Offset: 0x00005BE1
		public void SetVectorArray(int nameID, List<Vector4> values)
		{
			this.SetVectorArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x000079F8 File Offset: 0x00005BF8
		public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00007A10 File Offset: 0x00005C10
		public void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(nameID, values, values.Length);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00007A23 File Offset: 0x00005C23
		public void SetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00007A3F File Offset: 0x00005C3F
		public void SetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.SetMatrixArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00007A56 File Offset: 0x00005C56
		public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00007A6E File Offset: 0x00005C6E
		public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(nameID, values, values.Length);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0002E4F8 File Offset: 0x0002C6F8
		public int GetInt(string name)
		{
			return (int)this.GetFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0002E518 File Offset: 0x0002C718
		public int GetInt(int nameID)
		{
			return (int)this.GetFloatImpl(nameID);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0002E534 File Offset: 0x0002C734
		public Matrix4x4 GetMatrix(string name)
		{
			return this.GetMatrixImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0002E554 File Offset: 0x0002C754
		public Matrix4x4 GetMatrix(int nameID)
		{
			return this.GetMatrixImpl(nameID);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0002E570 File Offset: 0x0002C770
		public Il2CppStructArray<Color> GetColorArray(string name)
		{
			return this.GetColorArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0002E590 File Offset: 0x0002C790
		public Il2CppStructArray<Color> GetColorArray(int nameID)
		{
			return (this.GetColorArrayCountImpl(nameID) != 0) ? this.GetColorArrayImpl(nameID) : null;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0002E5B8 File Offset: 0x0002C7B8
		public Il2CppStructArray<Vector4> GetVectorArray(string name)
		{
			return this.GetVectorArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0002E5D8 File Offset: 0x0002C7D8
		public Il2CppStructArray<Vector4> GetVectorArray(int nameID)
		{
			return (this.GetVectorArrayCountImpl(nameID) != 0) ? this.GetVectorArrayImpl(nameID) : null;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0002E600 File Offset: 0x0002C800
		public Il2CppStructArray<Matrix4x4> GetMatrixArray(string name)
		{
			return this.GetMatrixArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x0002E620 File Offset: 0x0002C820
		public Il2CppStructArray<Matrix4x4> GetMatrixArray(int nameID)
		{
			return (this.GetMatrixArrayCountImpl(nameID) != 0) ? this.GetMatrixArrayImpl(nameID) : null;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00007A81 File Offset: 0x00005C81
		public void GetFloatArray(string name, List<float> values)
		{
			this.ExtractFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00007A92 File Offset: 0x00005C92
		public void GetFloatArray(int nameID, List<float> values)
		{
			this.ExtractFloatArray(nameID, values);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00007A9E File Offset: 0x00005C9E
		public void GetColorArray(string name, List<Color> values)
		{
			this.ExtractColorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00007AAF File Offset: 0x00005CAF
		public void GetColorArray(int nameID, List<Color> values)
		{
			this.ExtractColorArray(nameID, values);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00007ABB File Offset: 0x00005CBB
		public void GetVectorArray(string name, List<Vector4> values)
		{
			this.ExtractVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00007ACC File Offset: 0x00005CCC
		public void GetVectorArray(int nameID, List<Vector4> values)
		{
			this.ExtractVectorArray(nameID, values);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00007AD8 File Offset: 0x00005CD8
		public void GetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.ExtractMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00007AE9 File Offset: 0x00005CE9
		public void GetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.ExtractMatrixArray(nameID, values);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00007AF5 File Offset: 0x00005CF5
		public void GetMatrixImpl_Injected(int name, out Matrix4x4 ret)
		{
			Material.GetMatrixImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_CreateWithShader_Private_Static_Void_Material_Shader_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_CreateWithMaterial_Private_Static_Void_Material_Material_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_CreateWithString_Private_Static_Void_Material_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Material_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_set_shader_Public_set_Void_Shader_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_get_mainTexture_Public_get_Texture_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_set_mainTexture_Public_set_Void_Texture_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_get_mainTextureOffset_Public_get_Vector2_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_set_mainTextureOffset_Public_set_Void_Vector2_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_get_mainTextureScale_Public_get_Vector2_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_set_mainTextureScale_Public_set_Void_Vector2_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstPropertyNameIdByAttribute_Private_Int32_ShaderPropertyFlags_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_HasProperty_Public_Boolean_Int32_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_HasProperty_Public_Boolean_String_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_get_passCount_Public_get_Int32_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_CopyPropertiesFromMaterial_Public_Void_Material_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeywords_Private_Il2CppStringArray_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_get_shaderKeywords_Public_get_Il2CppStringArray_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_ComputeCRC_Public_Int32_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_GetFloatImpl_Private_Single_Int32_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_GetColorImpl_Private_Color_Int32_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_GetFloatArrayImpl_Private_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_GetFloatArrayCountImpl_Private_Int32_Int32_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureScaleAndOffsetImpl_Private_Vector4_Int32_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureOffsetImpl_Private_Void_Int32_Vector2_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureScaleImpl_Private_Void_Int32_Vector2_0;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatArray_Public_Void_String_Il2CppStructArray_1_Single_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_String_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_Int32_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Color_String_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Color_Int32_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_GetVector_Public_Vector4_String_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_GetVector_Public_Vector4_Int32_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture_String_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture_Int32_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_GetFloatArray_Public_Il2CppStructArray_1_Single_String_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_GetFloatArray_Public_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureOffset_Public_Void_String_Vector2_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureOffset_Public_Void_Int32_Vector2_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureScale_Public_Void_String_Vector2_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureScale_Public_Void_Int32_Vector2_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureOffset_Public_Vector2_String_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureOffset_Public_Vector2_Int32_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureScale_Public_Vector2_String_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureScale_Public_Vector2_Int32_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_SetColorImpl_Injected_Private_Void_Int32_byref_Color_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_GetColorImpl_Injected_Private_Void_Int32_byref_Color_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureScaleAndOffsetImpl_Injected_Private_Void_Int32_byref_Vector4_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureOffsetImpl_Injected_Private_Void_Int32_byref_Vector2_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureScaleImpl_Injected_Private_Void_Int32_byref_Vector2_0;

		// Token: 0x040006D3 RID: 1747
		private static readonly Material.GetDefaultMaterialDelegate GetDefaultMaterialDelegateField;

		// Token: 0x040006D4 RID: 1748
		private static readonly Material.GetDefaultParticleMaterialDelegate GetDefaultParticleMaterialDelegateField;

		// Token: 0x040006D5 RID: 1749
		private static readonly Material.GetDefaultLineMaterialDelegate GetDefaultLineMaterialDelegateField;

		// Token: 0x040006D6 RID: 1750
		private static readonly Material.get_shaderDelegate get_shaderDelegateField;

		// Token: 0x040006D7 RID: 1751
		private static readonly Material.get_renderQueueDelegate get_renderQueueDelegateField;

		// Token: 0x040006D8 RID: 1752
		private static readonly Material.get_rawRenderQueueDelegate get_rawRenderQueueDelegateField;

		// Token: 0x040006D9 RID: 1753
		private static readonly Material.IsKeywordEnabledDelegate IsKeywordEnabledDelegateField;

		// Token: 0x040006DA RID: 1754
		private static readonly Material.get_globalIlluminationFlagsDelegate get_globalIlluminationFlagsDelegateField;

		// Token: 0x040006DB RID: 1755
		private static readonly Material.set_globalIlluminationFlagsDelegate set_globalIlluminationFlagsDelegateField;

		// Token: 0x040006DC RID: 1756
		private static readonly Material.get_doubleSidedGIDelegate get_doubleSidedGIDelegateField;

		// Token: 0x040006DD RID: 1757
		private static readonly Material.set_doubleSidedGIDelegate set_doubleSidedGIDelegateField;

		// Token: 0x040006DE RID: 1758
		private static readonly Material.get_enableInstancingDelegate get_enableInstancingDelegateField;

		// Token: 0x040006DF RID: 1759
		private static readonly Material.set_enableInstancingDelegate set_enableInstancingDelegateField;

		// Token: 0x040006E0 RID: 1760
		private static readonly Material.SetShaderPassEnabledDelegate SetShaderPassEnabledDelegateField;

		// Token: 0x040006E1 RID: 1761
		private static readonly Material.GetShaderPassEnabledDelegate GetShaderPassEnabledDelegateField;

		// Token: 0x040006E2 RID: 1762
		private static readonly Material.GetPassNameDelegate GetPassNameDelegateField;

		// Token: 0x040006E3 RID: 1763
		private static readonly Material.FindPassDelegate FindPassDelegateField;

		// Token: 0x040006E4 RID: 1764
		private static readonly Material.SetOverrideTagDelegate SetOverrideTagDelegateField;

		// Token: 0x040006E5 RID: 1765
		private static readonly Material.GetTagImplDelegate GetTagImplDelegateField;

		// Token: 0x040006E6 RID: 1766
		private static readonly Material.LerpDelegate LerpDelegateField;

		// Token: 0x040006E7 RID: 1767
		private static readonly Material.SetPassDelegate SetPassDelegateField;

		// Token: 0x040006E8 RID: 1768
		private static readonly Material.GetTexturePropertyNamesDelegate GetTexturePropertyNamesDelegateField;

		// Token: 0x040006E9 RID: 1769
		private static readonly Material.GetTexturePropertyNameIDsDelegate GetTexturePropertyNameIDsDelegateField;

		// Token: 0x040006EA RID: 1770
		private static readonly Material.GetTexturePropertyNamesInternalDelegate GetTexturePropertyNamesInternalDelegateField;

		// Token: 0x040006EB RID: 1771
		private static readonly Material.GetTexturePropertyNameIDsInternalDelegate GetTexturePropertyNameIDsInternalDelegateField;

		// Token: 0x040006EC RID: 1772
		private static readonly Material.SetRenderTextureImplDelegate SetRenderTextureImplDelegateField;

		// Token: 0x040006ED RID: 1773
		private static readonly Material.SetBufferImplDelegate SetBufferImplDelegateField;

		// Token: 0x040006EE RID: 1774
		private static readonly Material.SetGraphicsBufferImplDelegate SetGraphicsBufferImplDelegateField;

		// Token: 0x040006EF RID: 1775
		private static readonly Material.SetConstantBufferImplDelegate SetConstantBufferImplDelegateField;

		// Token: 0x040006F0 RID: 1776
		private static readonly Material.SetConstantGraphicsBufferImplDelegate SetConstantGraphicsBufferImplDelegateField;

		// Token: 0x040006F1 RID: 1777
		private static readonly Material.SetVectorArrayImplDelegate SetVectorArrayImplDelegateField;

		// Token: 0x040006F2 RID: 1778
		private static readonly Material.SetColorArrayImplDelegate SetColorArrayImplDelegateField;

		// Token: 0x040006F3 RID: 1779
		private static readonly Material.SetMatrixArrayImplDelegate SetMatrixArrayImplDelegateField;

		// Token: 0x040006F4 RID: 1780
		private static readonly Material.GetVectorArrayImplDelegate GetVectorArrayImplDelegateField;

		// Token: 0x040006F5 RID: 1781
		private static readonly Material.GetColorArrayImplDelegate GetColorArrayImplDelegateField;

		// Token: 0x040006F6 RID: 1782
		private static readonly Material.GetMatrixArrayImplDelegate GetMatrixArrayImplDelegateField;

		// Token: 0x040006F7 RID: 1783
		private static readonly Material.GetVectorArrayCountImplDelegate GetVectorArrayCountImplDelegateField;

		// Token: 0x040006F8 RID: 1784
		private static readonly Material.GetColorArrayCountImplDelegate GetColorArrayCountImplDelegateField;

		// Token: 0x040006F9 RID: 1785
		private static readonly Material.GetMatrixArrayCountImplDelegate GetMatrixArrayCountImplDelegateField;

		// Token: 0x040006FA RID: 1786
		private static readonly Material.ExtractFloatArrayImplDelegate ExtractFloatArrayImplDelegateField;

		// Token: 0x040006FB RID: 1787
		private static readonly Material.ExtractVectorArrayImplDelegate ExtractVectorArrayImplDelegateField;

		// Token: 0x040006FC RID: 1788
		private static readonly Material.ExtractColorArrayImplDelegate ExtractColorArrayImplDelegateField;

		// Token: 0x040006FD RID: 1789
		private static readonly Material.ExtractMatrixArrayImplDelegate ExtractMatrixArrayImplDelegateField;

		// Token: 0x040006FE RID: 1790
		private static readonly Material.GetMatrixImpl_InjectedDelegate GetMatrixImpl_InjectedDelegateField;

		// Token: 0x020005D2 RID: 1490
		// (Invoke) Token: 0x060029DA RID: 10714
		private delegate IntPtr GetDefaultMaterialDelegate();

		// Token: 0x020005D3 RID: 1491
		// (Invoke) Token: 0x060029DC RID: 10716
		private delegate IntPtr GetDefaultParticleMaterialDelegate();

		// Token: 0x020005D4 RID: 1492
		// (Invoke) Token: 0x060029DE RID: 10718
		private delegate IntPtr GetDefaultLineMaterialDelegate();

		// Token: 0x020005D5 RID: 1493
		// (Invoke) Token: 0x060029E0 RID: 10720
		private delegate IntPtr get_shaderDelegate(IntPtr @this);

		// Token: 0x020005D6 RID: 1494
		// (Invoke) Token: 0x060029E2 RID: 10722
		private delegate int get_renderQueueDelegate(IntPtr @this);

		// Token: 0x020005D7 RID: 1495
		// (Invoke) Token: 0x060029E4 RID: 10724
		private delegate int get_rawRenderQueueDelegate(IntPtr @this);

		// Token: 0x020005D8 RID: 1496
		// (Invoke) Token: 0x060029E6 RID: 10726
		private delegate bool IsKeywordEnabledDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x020005D9 RID: 1497
		// (Invoke) Token: 0x060029E8 RID: 10728
		private delegate MaterialGlobalIlluminationFlags get_globalIlluminationFlagsDelegate(IntPtr @this);

		// Token: 0x020005DA RID: 1498
		// (Invoke) Token: 0x060029EA RID: 10730
		private delegate void set_globalIlluminationFlagsDelegate(IntPtr @this, MaterialGlobalIlluminationFlags value);

		// Token: 0x020005DB RID: 1499
		// (Invoke) Token: 0x060029EC RID: 10732
		private delegate bool get_doubleSidedGIDelegate(IntPtr @this);

		// Token: 0x020005DC RID: 1500
		// (Invoke) Token: 0x060029EE RID: 10734
		private delegate void set_doubleSidedGIDelegate(IntPtr @this, bool value);

		// Token: 0x020005DD RID: 1501
		// (Invoke) Token: 0x060029F0 RID: 10736
		private delegate bool get_enableInstancingDelegate(IntPtr @this);

		// Token: 0x020005DE RID: 1502
		// (Invoke) Token: 0x060029F2 RID: 10738
		private delegate void set_enableInstancingDelegate(IntPtr @this, bool value);

		// Token: 0x020005DF RID: 1503
		// (Invoke) Token: 0x060029F4 RID: 10740
		private delegate void SetShaderPassEnabledDelegate(IntPtr @this, IntPtr passName, bool enabled);

		// Token: 0x020005E0 RID: 1504
		// (Invoke) Token: 0x060029F6 RID: 10742
		private delegate bool GetShaderPassEnabledDelegate(IntPtr @this, IntPtr passName);

		// Token: 0x020005E1 RID: 1505
		// (Invoke) Token: 0x060029F8 RID: 10744
		private delegate IntPtr GetPassNameDelegate(IntPtr @this, int pass);

		// Token: 0x020005E2 RID: 1506
		// (Invoke) Token: 0x060029FA RID: 10746
		private delegate int FindPassDelegate(IntPtr @this, IntPtr passName);

		// Token: 0x020005E3 RID: 1507
		// (Invoke) Token: 0x060029FC RID: 10748
		private delegate void SetOverrideTagDelegate(IntPtr @this, IntPtr tag, IntPtr val);

		// Token: 0x020005E4 RID: 1508
		// (Invoke) Token: 0x060029FE RID: 10750
		private delegate IntPtr GetTagImplDelegate(IntPtr @this, IntPtr tag, bool currentSubShaderOnly, IntPtr defaultValue);

		// Token: 0x020005E5 RID: 1509
		// (Invoke) Token: 0x06002A00 RID: 10752
		private delegate void LerpDelegate(IntPtr @this, IntPtr start, IntPtr end, float t);

		// Token: 0x020005E6 RID: 1510
		// (Invoke) Token: 0x06002A02 RID: 10754
		private delegate bool SetPassDelegate(IntPtr @this, int pass);

		// Token: 0x020005E7 RID: 1511
		// (Invoke) Token: 0x06002A04 RID: 10756
		private delegate IntPtr GetTexturePropertyNamesDelegate(IntPtr @this);

		// Token: 0x020005E8 RID: 1512
		// (Invoke) Token: 0x06002A06 RID: 10758
		private delegate IntPtr GetTexturePropertyNameIDsDelegate(IntPtr @this);

		// Token: 0x020005E9 RID: 1513
		// (Invoke) Token: 0x06002A08 RID: 10760
		private delegate void GetTexturePropertyNamesInternalDelegate(IntPtr @this, IntPtr outNames);

		// Token: 0x020005EA RID: 1514
		// (Invoke) Token: 0x06002A0A RID: 10762
		private delegate void GetTexturePropertyNameIDsInternalDelegate(IntPtr @this, IntPtr outNames);

		// Token: 0x020005EB RID: 1515
		// (Invoke) Token: 0x06002A0C RID: 10764
		private delegate void SetRenderTextureImplDelegate(IntPtr @this, int name, IntPtr value, UnityEngine.Rendering.RenderTextureSubElement element);

		// Token: 0x020005EC RID: 1516
		// (Invoke) Token: 0x06002A0E RID: 10766
		private delegate void SetBufferImplDelegate(IntPtr @this, int name, IntPtr value);

		// Token: 0x020005ED RID: 1517
		// (Invoke) Token: 0x06002A10 RID: 10768
		private delegate void SetGraphicsBufferImplDelegate(IntPtr @this, int name, IntPtr value);

		// Token: 0x020005EE RID: 1518
		// (Invoke) Token: 0x06002A12 RID: 10770
		private delegate void SetConstantBufferImplDelegate(IntPtr @this, int name, IntPtr value, int offset, int size);

		// Token: 0x020005EF RID: 1519
		// (Invoke) Token: 0x06002A14 RID: 10772
		private delegate void SetConstantGraphicsBufferImplDelegate(IntPtr @this, int name, IntPtr value, int offset, int size);

		// Token: 0x020005F0 RID: 1520
		// (Invoke) Token: 0x06002A16 RID: 10774
		private delegate void SetVectorArrayImplDelegate(IntPtr @this, int name, IntPtr values, int count);

		// Token: 0x020005F1 RID: 1521
		// (Invoke) Token: 0x06002A18 RID: 10776
		private delegate void SetColorArrayImplDelegate(IntPtr @this, int name, IntPtr values, int count);

		// Token: 0x020005F2 RID: 1522
		// (Invoke) Token: 0x06002A1A RID: 10778
		private delegate void SetMatrixArrayImplDelegate(IntPtr @this, int name, IntPtr values, int count);

		// Token: 0x020005F3 RID: 1523
		// (Invoke) Token: 0x06002A1C RID: 10780
		private delegate IntPtr GetVectorArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x020005F4 RID: 1524
		// (Invoke) Token: 0x06002A1E RID: 10782
		private delegate IntPtr GetColorArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x020005F5 RID: 1525
		// (Invoke) Token: 0x06002A20 RID: 10784
		private delegate IntPtr GetMatrixArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x020005F6 RID: 1526
		// (Invoke) Token: 0x06002A22 RID: 10786
		private delegate int GetVectorArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x020005F7 RID: 1527
		// (Invoke) Token: 0x06002A24 RID: 10788
		private delegate int GetColorArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x020005F8 RID: 1528
		// (Invoke) Token: 0x06002A26 RID: 10790
		private delegate int GetMatrixArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x020005F9 RID: 1529
		// (Invoke) Token: 0x06002A28 RID: 10792
		private delegate void ExtractFloatArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x020005FA RID: 1530
		// (Invoke) Token: 0x06002A2A RID: 10794
		private delegate void ExtractVectorArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x020005FB RID: 1531
		// (Invoke) Token: 0x06002A2C RID: 10796
		private delegate void ExtractColorArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x020005FC RID: 1532
		// (Invoke) Token: 0x06002A2E RID: 10798
		private delegate void ExtractMatrixArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x020005FD RID: 1533
		// (Invoke) Token: 0x06002A30 RID: 10800
		private delegate void GetMatrixImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);
	}
}
