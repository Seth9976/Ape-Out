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
	// Token: 0x02000071 RID: 113
	public sealed class Shader : Object
	{
		// Token: 0x06000932 RID: 2354 RVA: 0x0002AE74 File Offset: 0x00029074
		// Note: this type is marked as 'beforefieldinit'.
		static Shader()
		{
			Il2CppClassPointerStore<Shader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Shader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shader>.NativeClassPtr);
			Shader.NativeMethodInfoPtr_Find_Public_Static_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663907);
			Shader.NativeMethodInfoPtr_get_isSupported_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663908);
			Shader.NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663909);
			Shader.NativeMethodInfoPtr_DisableKeyword_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663910);
			Shader.NativeMethodInfoPtr_TagToID_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663911);
			Shader.NativeMethodInfoPtr_PropertyToID_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663912);
			Shader.NativeMethodInfoPtr_SetGlobalFloatImpl_Private_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663913);
			Shader.NativeMethodInfoPtr_SetGlobalVectorImpl_Private_Static_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663914);
			Shader.NativeMethodInfoPtr_SetGlobalFloatArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663915);
			Shader.NativeMethodInfoPtr_SetGlobalFloatArray_Private_Static_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663916);
			Shader.NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663917);
			Shader.NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663918);
			Shader.NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663919);
			Shader.NativeMethodInfoPtr_SetGlobalFloatArray_Public_Static_Void_Int32_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663920);
			Shader.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663921);
			Shader.NativeMethodInfoPtr_SetGlobalVectorImpl_Injected_Private_Static_Void_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663922);
			Shader.FindBuiltinDelegateField = IL2CPP.ResolveICall<Shader.FindBuiltinDelegate>("UnityEngine.Shader::FindBuiltin");
			Shader.get_maximumLODDelegateField = IL2CPP.ResolveICall<Shader.get_maximumLODDelegate>("UnityEngine.Shader::get_maximumLOD");
			Shader.set_maximumLODDelegateField = IL2CPP.ResolveICall<Shader.set_maximumLODDelegate>("UnityEngine.Shader::set_maximumLOD");
			Shader.get_globalMaximumLODDelegateField = IL2CPP.ResolveICall<Shader.get_globalMaximumLODDelegate>("UnityEngine.Shader::get_globalMaximumLOD");
			Shader.set_globalMaximumLODDelegateField = IL2CPP.ResolveICall<Shader.set_globalMaximumLODDelegate>("UnityEngine.Shader::set_globalMaximumLOD");
			Shader.get_globalRenderPipelineDelegateField = IL2CPP.ResolveICall<Shader.get_globalRenderPipelineDelegate>("UnityEngine.Shader::get_globalRenderPipeline");
			Shader.set_globalRenderPipelineDelegateField = IL2CPP.ResolveICall<Shader.set_globalRenderPipelineDelegate>("UnityEngine.Shader::set_globalRenderPipeline");
			Shader.IsKeywordEnabledDelegateField = IL2CPP.ResolveICall<Shader.IsKeywordEnabledDelegate>("UnityEngine.Shader::IsKeywordEnabled");
			Shader.get_renderQueueDelegateField = IL2CPP.ResolveICall<Shader.get_renderQueueDelegate>("UnityEngine.Shader::get_renderQueue");
			Shader.get_disableBatchingDelegateField = IL2CPP.ResolveICall<Shader.get_disableBatchingDelegate>("UnityEngine.Shader::get_disableBatching");
			Shader.WarmupAllShadersDelegateField = IL2CPP.ResolveICall<Shader.WarmupAllShadersDelegate>("UnityEngine.Shader::WarmupAllShaders");
			Shader.IDToTagDelegateField = IL2CPP.ResolveICall<Shader.IDToTagDelegate>("UnityEngine.Shader::IDToTag");
			Shader.GetDependencyDelegateField = IL2CPP.ResolveICall<Shader.GetDependencyDelegate>("UnityEngine.Shader::GetDependency");
			Shader.get_passCountDelegateField = IL2CPP.ResolveICall<Shader.get_passCountDelegate>("UnityEngine.Shader::get_passCount");
			Shader.Internal_FindPassTagValueDelegateField = IL2CPP.ResolveICall<Shader.Internal_FindPassTagValueDelegate>("UnityEngine.Shader::Internal_FindPassTagValue");
			Shader.SetGlobalTextureImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalTextureImplDelegate>("UnityEngine.Shader::SetGlobalTextureImpl");
			Shader.SetGlobalRenderTextureImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalRenderTextureImplDelegate>("UnityEngine.Shader::SetGlobalRenderTextureImpl");
			Shader.SetGlobalBufferImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalBufferImplDelegate>("UnityEngine.Shader::SetGlobalBufferImpl");
			Shader.SetGlobalGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalGraphicsBufferImplDelegate>("UnityEngine.Shader::SetGlobalGraphicsBufferImpl");
			Shader.SetGlobalConstantBufferImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalConstantBufferImplDelegate>("UnityEngine.Shader::SetGlobalConstantBufferImpl");
			Shader.SetGlobalConstantGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalConstantGraphicsBufferImplDelegate>("UnityEngine.Shader::SetGlobalConstantGraphicsBufferImpl");
			Shader.GetGlobalFloatImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalFloatImplDelegate>("UnityEngine.Shader::GetGlobalFloatImpl");
			Shader.GetGlobalTextureImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalTextureImplDelegate>("UnityEngine.Shader::GetGlobalTextureImpl");
			Shader.SetGlobalVectorArrayImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalVectorArrayImplDelegate>("UnityEngine.Shader::SetGlobalVectorArrayImpl");
			Shader.SetGlobalMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalMatrixArrayImplDelegate>("UnityEngine.Shader::SetGlobalMatrixArrayImpl");
			Shader.GetGlobalFloatArrayImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalFloatArrayImplDelegate>("UnityEngine.Shader::GetGlobalFloatArrayImpl");
			Shader.GetGlobalVectorArrayImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalVectorArrayImplDelegate>("UnityEngine.Shader::GetGlobalVectorArrayImpl");
			Shader.GetGlobalMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalMatrixArrayImplDelegate>("UnityEngine.Shader::GetGlobalMatrixArrayImpl");
			Shader.GetGlobalFloatArrayCountImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalFloatArrayCountImplDelegate>("UnityEngine.Shader::GetGlobalFloatArrayCountImpl");
			Shader.GetGlobalVectorArrayCountImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalVectorArrayCountImplDelegate>("UnityEngine.Shader::GetGlobalVectorArrayCountImpl");
			Shader.GetGlobalMatrixArrayCountImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalMatrixArrayCountImplDelegate>("UnityEngine.Shader::GetGlobalMatrixArrayCountImpl");
			Shader.ExtractGlobalFloatArrayImplDelegateField = IL2CPP.ResolveICall<Shader.ExtractGlobalFloatArrayImplDelegate>("UnityEngine.Shader::ExtractGlobalFloatArrayImpl");
			Shader.ExtractGlobalVectorArrayImplDelegateField = IL2CPP.ResolveICall<Shader.ExtractGlobalVectorArrayImplDelegate>("UnityEngine.Shader::ExtractGlobalVectorArrayImpl");
			Shader.ExtractGlobalMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Shader.ExtractGlobalMatrixArrayImplDelegate>("UnityEngine.Shader::ExtractGlobalMatrixArrayImpl");
			Shader.GetPropertyNameDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyNameDelegate>("UnityEngine.Shader::GetPropertyName");
			Shader.GetPropertyNameIdDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyNameIdDelegate>("UnityEngine.Shader::GetPropertyNameId");
			Shader.GetPropertyTypeDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyTypeDelegate>("UnityEngine.Shader::GetPropertyType");
			Shader.GetPropertyDescriptionDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyDescriptionDelegate>("UnityEngine.Shader::GetPropertyDescription");
			Shader.GetPropertyFlagsDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyFlagsDelegate>("UnityEngine.Shader::GetPropertyFlags");
			Shader.GetPropertyAttributesDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyAttributesDelegate>("UnityEngine.Shader::GetPropertyAttributes");
			Shader.GetPropertyTextureDimensionDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyTextureDimensionDelegate>("UnityEngine.Shader::GetPropertyTextureDimension");
			Shader.GetPropertyTextureDefaultNameDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyTextureDefaultNameDelegate>("UnityEngine.Shader::GetPropertyTextureDefaultName");
			Shader.FindTextureStackImplDelegateField = IL2CPP.ResolveICall<Shader.FindTextureStackImplDelegate>("UnityEngine.Shader::FindTextureStackImpl");
			Shader.GetPropertyCountDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyCountDelegate>("UnityEngine.Shader::GetPropertyCount");
			Shader.FindPropertyIndexDelegateField = IL2CPP.ResolveICall<Shader.FindPropertyIndexDelegate>("UnityEngine.Shader::FindPropertyIndex");
			Shader.SetGlobalMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalMatrixImpl_InjectedDelegate>("UnityEngine.Shader::SetGlobalMatrixImpl_Injected");
			Shader.GetGlobalVectorImpl_InjectedDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalVectorImpl_InjectedDelegate>("UnityEngine.Shader::GetGlobalVectorImpl_Injected");
			Shader.GetGlobalMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalMatrixImpl_InjectedDelegate>("UnityEngine.Shader::GetGlobalMatrixImpl_Injected");
			Shader.GetPropertyDefaultValue_InjectedDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyDefaultValue_InjectedDelegate>("UnityEngine.Shader::GetPropertyDefaultValue_Injected");
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0002B2C4 File Offset: 0x000294C4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 488606, RefRangeEnd = 488615, XrefRangeStart = 488601, XrefRangeEnd = 488606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Shader Find(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_Find_Public_Static_Shader_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0002B308 File Offset: 0x00029508
		public unsafe bool isSupported
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 488619, RefRangeEnd = 488624, XrefRangeStart = 488615, XrefRangeEnd = 488619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_isSupported_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0002B344 File Offset: 0x00029544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488624, XrefRangeEnd = 488628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableKeyword(string keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0002B37C File Offset: 0x0002957C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488628, XrefRangeEnd = 488632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableKeyword(string keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_DisableKeyword_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0002B3B4 File Offset: 0x000295B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488632, XrefRangeEnd = 488636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TagToID(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_TagToID_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0002B3F8 File Offset: 0x000295F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488636, XrefRangeEnd = 488640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PropertyToID(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_PropertyToID_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0002B43C File Offset: 0x0002963C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488644, RefRangeEnd = 488646, XrefRangeStart = 488640, XrefRangeEnd = 488644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloatImpl(int name, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloatImpl_Private_Static_Void_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0002B47C File Offset: 0x0002967C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488646, XrefRangeEnd = 488648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVectorImpl(int name, Vector4 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVectorImpl_Private_Static_Void_Int32_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0002B4BC File Offset: 0x000296BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488648, XrefRangeEnd = 488652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloatArrayImpl(int name, Il2CppStructArray<float> values, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloatArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0002B510 File Offset: 0x00029710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488652, XrefRangeEnd = 488674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloatArray(int name, Il2CppStructArray<float> values, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloatArray_Private_Static_Void_Int32_Il2CppStructArray_1_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0002B564 File Offset: 0x00029764
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488644, RefRangeEnd = 488646, XrefRangeStart = 488644, XrefRangeEnd = 488646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloat(int nameID, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0002B5A4 File Offset: 0x000297A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488678, RefRangeEnd = 488680, XrefRangeStart = 488674, XrefRangeEnd = 488678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVector(string name, Vector4 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_String_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0002B5E8 File Offset: 0x000297E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488680, XrefRangeEnd = 488682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVector(int nameID, Vector4 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_Int32_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0002B628 File Offset: 0x00029828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488693, RefRangeEnd = 488695, XrefRangeStart = 488682, XrefRangeEnd = 488693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloatArray_Public_Static_Void_Int32_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0002B66C File Offset: 0x0002986C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488695, XrefRangeEnd = 488698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0002B6A8 File Offset: 0x000298A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488698, XrefRangeEnd = 488702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVectorImpl_Injected_Private_Static_Void_Int32_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0000708A File Offset: 0x0000528A
		public Shader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x0002B6E8 File Offset: 0x000298E8
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00007093 File Offset: 0x00005293
		public static UnityEngine.Rendering.ShaderHardwareTier globalShaderHardwareTier
		{
			get
			{
				return (UnityEngine.Rendering.ShaderHardwareTier)Graphics.activeTier;
			}
			set
			{
				Graphics.activeTier = (UnityEngine.Rendering.GraphicsTier)value;
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0002B700 File Offset: 0x00029900
		public static Shader FindBuiltin(string name)
		{
			IntPtr intPtr = Shader.FindBuiltinDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x0000709D File Offset: 0x0000529D
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x000070AF File Offset: 0x000052AF
		public int maximumLOD
		{
			get
			{
				return Shader.get_maximumLODDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Shader.set_maximumLODDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x000070C2 File Offset: 0x000052C2
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x000070CE File Offset: 0x000052CE
		public static int globalMaximumLOD
		{
			get
			{
				return Shader.get_globalMaximumLODDelegateField();
			}
			set
			{
				Shader.set_globalMaximumLODDelegateField(value);
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0002B72C File Offset: 0x0002992C
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x000070DB File Offset: 0x000052DB
		public static string globalRenderPipeline
		{
			get
			{
				IntPtr intPtr = Shader.get_globalRenderPipelineDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				Shader.set_globalRenderPipelineDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000070ED File Offset: 0x000052ED
		public static bool IsKeywordEnabled(string keyword)
		{
			return Shader.IsKeywordEnabledDelegateField(IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x000070FF File Offset: 0x000052FF
		public int renderQueue
		{
			get
			{
				return Shader.get_renderQueueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00007111 File Offset: 0x00005311
		public DisableBatchingType disableBatching
		{
			get
			{
				return Shader.get_disableBatchingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00007123 File Offset: 0x00005323
		public static void WarmupAllShaders()
		{
			Shader.WarmupAllShadersDelegateField();
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0002B74C File Offset: 0x0002994C
		public static string IDToTag(int name)
		{
			IntPtr intPtr = Shader.IDToTagDelegateField(name);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0002B76C File Offset: 0x0002996C
		public Shader GetDependency(string name)
		{
			IntPtr intPtr = Shader.GetDependencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x0000712F File Offset: 0x0000532F
		public int passCount
		{
			get
			{
				return Shader.get_passCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0002B7A0 File Offset: 0x000299A0
		public UnityEngine.Rendering.ShaderTagId FindPassTagValue(int passIndex, UnityEngine.Rendering.ShaderTagId tagName)
		{
			bool flag = passIndex < 0 || passIndex >= this.passCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("passIndex");
			}
			int num = this.Internal_FindPassTagValue(passIndex, tagName.id);
			return new UnityEngine.Rendering.ShaderTagId
			{
				id = num
			};
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00007141 File Offset: 0x00005341
		public int Internal_FindPassTagValue(int passIndex, int tagName)
		{
			return Shader.Internal_FindPassTagValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), passIndex, tagName);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00007155 File Offset: 0x00005355
		public static void SetGlobalMatrixImpl(int name, Matrix4x4 value)
		{
			Shader.SetGlobalMatrixImpl_Injected(name, ref value);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0000715F File Offset: 0x0000535F
		public static void SetGlobalTextureImpl(int name, Texture value)
		{
			Shader.SetGlobalTextureImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00007172 File Offset: 0x00005372
		public static void SetGlobalRenderTextureImpl(int name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			Shader.SetGlobalRenderTextureImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value), element);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00007186 File Offset: 0x00005386
		public static void SetGlobalBufferImpl(int name, ComputeBuffer value)
		{
			Shader.SetGlobalBufferImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00007199 File Offset: 0x00005399
		public static void SetGlobalGraphicsBufferImpl(int name, GraphicsBuffer value)
		{
			Shader.SetGlobalGraphicsBufferImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x000071AC File Offset: 0x000053AC
		public static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantBufferImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x000071C1 File Offset: 0x000053C1
		public static void SetGlobalConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantGraphicsBufferImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x000071D6 File Offset: 0x000053D6
		public static float GetGlobalFloatImpl(int name)
		{
			return Shader.GetGlobalFloatImplDelegateField(name);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0002B7F8 File Offset: 0x000299F8
		public static Vector4 GetGlobalVectorImpl(int name)
		{
			Vector4 vector;
			Shader.GetGlobalVectorImpl_Injected(name, out vector);
			return vector;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0002B810 File Offset: 0x00029A10
		public static Matrix4x4 GetGlobalMatrixImpl(int name)
		{
			Matrix4x4 matrix4x;
			Shader.GetGlobalMatrixImpl_Injected(name, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0002B828 File Offset: 0x00029A28
		public static Texture GetGlobalTextureImpl(int name)
		{
			IntPtr intPtr = Shader.GetGlobalTextureImplDelegateField(name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x000071E3 File Offset: 0x000053E3
		public static void SetGlobalVectorArrayImpl(int name, Il2CppStructArray<Vector4> values, int count)
		{
			Shader.SetGlobalVectorArrayImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x000071F7 File Offset: 0x000053F7
		public static void SetGlobalMatrixArrayImpl(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			Shader.SetGlobalMatrixArrayImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0002B850 File Offset: 0x00029A50
		public static Il2CppStructArray<float> GetGlobalFloatArrayImpl(int name)
		{
			IntPtr intPtr = Shader.GetGlobalFloatArrayImplDelegateField(name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0002B878 File Offset: 0x00029A78
		public static Il2CppStructArray<Vector4> GetGlobalVectorArrayImpl(int name)
		{
			IntPtr intPtr = Shader.GetGlobalVectorArrayImplDelegateField(name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0002B8A0 File Offset: 0x00029AA0
		public static Il2CppStructArray<Matrix4x4> GetGlobalMatrixArrayImpl(int name)
		{
			IntPtr intPtr = Shader.GetGlobalMatrixArrayImplDelegateField(name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0000720B File Offset: 0x0000540B
		public static int GetGlobalFloatArrayCountImpl(int name)
		{
			return Shader.GetGlobalFloatArrayCountImplDelegateField(name);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00007218 File Offset: 0x00005418
		public static int GetGlobalVectorArrayCountImpl(int name)
		{
			return Shader.GetGlobalVectorArrayCountImplDelegateField(name);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00007225 File Offset: 0x00005425
		public static int GetGlobalMatrixArrayCountImpl(int name)
		{
			return Shader.GetGlobalMatrixArrayCountImplDelegateField(name);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00007232 File Offset: 0x00005432
		public static void ExtractGlobalFloatArrayImpl(int name, [Out] Il2CppStructArray<float> val)
		{
			Shader.ExtractGlobalFloatArrayImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00007245 File Offset: 0x00005445
		public static void ExtractGlobalVectorArrayImpl(int name, [Out] Il2CppStructArray<Vector4> val)
		{
			Shader.ExtractGlobalVectorArrayImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00007258 File Offset: 0x00005458
		public static void ExtractGlobalMatrixArrayImpl(int name, [Out] Il2CppStructArray<Matrix4x4> val)
		{
			Shader.ExtractGlobalMatrixArrayImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0002B8C8 File Offset: 0x00029AC8
		public static void SetGlobalVectorArray(int name, Il2CppStructArray<Vector4> values, int count)
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
			Shader.SetGlobalVectorArrayImpl(name, values, count);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0002B924 File Offset: 0x00029B24
		public static void SetGlobalMatrixArray(int name, Il2CppStructArray<Matrix4x4> values, int count)
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
			Shader.SetGlobalMatrixArrayImpl(name, values, count);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0002B980 File Offset: 0x00029B80
		public static void ExtractGlobalFloatArray(int name, List<float> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int globalFloatArrayCountImpl = Shader.GetGlobalFloatArrayCountImpl(name);
			bool flag2 = globalFloatArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<float>(values, globalFloatArrayCountImpl);
				Shader.ExtractGlobalFloatArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<float>>());
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0002B9D4 File Offset: 0x00029BD4
		public static void ExtractGlobalVectorArray(int name, List<Vector4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int globalVectorArrayCountImpl = Shader.GetGlobalVectorArrayCountImpl(name);
			bool flag2 = globalVectorArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Vector4>(values, globalVectorArrayCountImpl);
				Shader.ExtractGlobalVectorArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Vector4>>());
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0002BA28 File Offset: 0x00029C28
		public static void ExtractGlobalMatrixArray(int name, List<Matrix4x4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int globalMatrixArrayCountImpl = Shader.GetGlobalMatrixArrayCountImpl(name);
			bool flag2 = globalMatrixArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Matrix4x4>(values, globalMatrixArrayCountImpl);
				Shader.ExtractGlobalMatrixArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Matrix4x4>>());
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0000726B File Offset: 0x0000546B
		public static void SetGlobalFloat(string name, float value)
		{
			Shader.SetGlobalFloatImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0000727B File Offset: 0x0000547B
		public static void SetGlobalInt(string name, int value)
		{
			Shader.SetGlobalFloatImpl(Shader.PropertyToID(name), (float)value);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0000728C File Offset: 0x0000548C
		public static void SetGlobalInt(int nameID, int value)
		{
			Shader.SetGlobalFloatImpl(nameID, (float)value);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00007298 File Offset: 0x00005498
		public static void SetGlobalColor(string name, Color value)
		{
			Shader.SetGlobalVectorImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000072AD File Offset: 0x000054AD
		public static void SetGlobalColor(int nameID, Color value)
		{
			Shader.SetGlobalVectorImpl(nameID, value);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x000072BD File Offset: 0x000054BD
		public static void SetGlobalMatrix(string name, Matrix4x4 value)
		{
			Shader.SetGlobalMatrixImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x000072CD File Offset: 0x000054CD
		public static void SetGlobalMatrix(int nameID, Matrix4x4 value)
		{
			Shader.SetGlobalMatrixImpl(nameID, value);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000072D8 File Offset: 0x000054D8
		public static void SetGlobalTexture(string name, Texture value)
		{
			Shader.SetGlobalTextureImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x000072E8 File Offset: 0x000054E8
		public static void SetGlobalTexture(int nameID, Texture value)
		{
			Shader.SetGlobalTextureImpl(nameID, value);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000072F3 File Offset: 0x000054F3
		public static void SetGlobalTexture(string name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			Shader.SetGlobalRenderTextureImpl(Shader.PropertyToID(name), value, element);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00007304 File Offset: 0x00005504
		public static void SetGlobalTexture(int nameID, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			Shader.SetGlobalRenderTextureImpl(nameID, value, element);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00007310 File Offset: 0x00005510
		public static void SetGlobalBuffer(string name, ComputeBuffer value)
		{
			Shader.SetGlobalBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00007320 File Offset: 0x00005520
		public static void SetGlobalBuffer(int nameID, ComputeBuffer value)
		{
			Shader.SetGlobalBufferImpl(nameID, value);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0000732B File Offset: 0x0000552B
		public static void SetGlobalBuffer(string name, GraphicsBuffer value)
		{
			Shader.SetGlobalGraphicsBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0000733B File Offset: 0x0000553B
		public static void SetGlobalBuffer(int nameID, GraphicsBuffer value)
		{
			Shader.SetGlobalGraphicsBufferImpl(nameID, value);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00007346 File Offset: 0x00005546
		public static void SetGlobalConstantBuffer(string name, ComputeBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00007358 File Offset: 0x00005558
		public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00007365 File Offset: 0x00005565
		public static void SetGlobalConstantBuffer(string name, GraphicsBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantGraphicsBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00007377 File Offset: 0x00005577
		public static void SetGlobalConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantGraphicsBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00007384 File Offset: 0x00005584
		public static void SetGlobalFloatArray(string name, List<float> values)
		{
			Shader.SetGlobalFloatArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0000739F File Offset: 0x0000559F
		public static void SetGlobalFloatArray(int nameID, List<float> values)
		{
			Shader.SetGlobalFloatArray(nameID, NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x000073B5 File Offset: 0x000055B5
		public static void SetGlobalFloatArray(string name, Il2CppStructArray<float> values)
		{
			Shader.SetGlobalFloatArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x000073CC File Offset: 0x000055CC
		public static void SetGlobalVectorArray(string name, List<Vector4> values)
		{
			Shader.SetGlobalVectorArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x000073E7 File Offset: 0x000055E7
		public static void SetGlobalVectorArray(int nameID, List<Vector4> values)
		{
			Shader.SetGlobalVectorArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000073FD File Offset: 0x000055FD
		public static void SetGlobalVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			Shader.SetGlobalVectorArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00007414 File Offset: 0x00005614
		public static void SetGlobalVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			Shader.SetGlobalVectorArray(nameID, values, values.Length);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00007426 File Offset: 0x00005626
		public static void SetGlobalMatrixArray(string name, List<Matrix4x4> values)
		{
			Shader.SetGlobalMatrixArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00007441 File Offset: 0x00005641
		public static void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
		{
			Shader.SetGlobalMatrixArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00007457 File Offset: 0x00005657
		public static void SetGlobalMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			Shader.SetGlobalMatrixArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0000746E File Offset: 0x0000566E
		public static void SetGlobalMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			Shader.SetGlobalMatrixArray(nameID, values, values.Length);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0002BA7C File Offset: 0x00029C7C
		public static float GetGlobalFloat(string name)
		{
			return Shader.GetGlobalFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0002BA9C File Offset: 0x00029C9C
		public static float GetGlobalFloat(int nameID)
		{
			return Shader.GetGlobalFloatImpl(nameID);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0002BAB4 File Offset: 0x00029CB4
		public static int GetGlobalInt(string name)
		{
			return (int)Shader.GetGlobalFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0002BAD4 File Offset: 0x00029CD4
		public static int GetGlobalInt(int nameID)
		{
			return (int)Shader.GetGlobalFloatImpl(nameID);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0002BAF0 File Offset: 0x00029CF0
		public static Vector4 GetGlobalVector(string name)
		{
			return Shader.GetGlobalVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0002BB10 File Offset: 0x00029D10
		public static Vector4 GetGlobalVector(int nameID)
		{
			return Shader.GetGlobalVectorImpl(nameID);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0002BB28 File Offset: 0x00029D28
		public static Color GetGlobalColor(string name)
		{
			return Shader.GetGlobalVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0002BB4C File Offset: 0x00029D4C
		public static Color GetGlobalColor(int nameID)
		{
			return Shader.GetGlobalVectorImpl(nameID);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0002BB6C File Offset: 0x00029D6C
		public static Matrix4x4 GetGlobalMatrix(string name)
		{
			return Shader.GetGlobalMatrixImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0002BB8C File Offset: 0x00029D8C
		public static Matrix4x4 GetGlobalMatrix(int nameID)
		{
			return Shader.GetGlobalMatrixImpl(nameID);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0002BBA4 File Offset: 0x00029DA4
		public static Texture GetGlobalTexture(string name)
		{
			return Shader.GetGlobalTextureImpl(Shader.PropertyToID(name));
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0002BBC4 File Offset: 0x00029DC4
		public static Texture GetGlobalTexture(int nameID)
		{
			return Shader.GetGlobalTextureImpl(nameID);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0002BBDC File Offset: 0x00029DDC
		public static Il2CppStructArray<float> GetGlobalFloatArray(string name)
		{
			return Shader.GetGlobalFloatArray(Shader.PropertyToID(name));
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0002BBFC File Offset: 0x00029DFC
		public static Il2CppStructArray<float> GetGlobalFloatArray(int nameID)
		{
			return (Shader.GetGlobalFloatArrayCountImpl(nameID) != 0) ? Shader.GetGlobalFloatArrayImpl(nameID) : null;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0002BC20 File Offset: 0x00029E20
		public static Il2CppStructArray<Vector4> GetGlobalVectorArray(string name)
		{
			return Shader.GetGlobalVectorArray(Shader.PropertyToID(name));
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0002BC40 File Offset: 0x00029E40
		public static Il2CppStructArray<Vector4> GetGlobalVectorArray(int nameID)
		{
			return (Shader.GetGlobalVectorArrayCountImpl(nameID) != 0) ? Shader.GetGlobalVectorArrayImpl(nameID) : null;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0002BC64 File Offset: 0x00029E64
		public static Il2CppStructArray<Matrix4x4> GetGlobalMatrixArray(string name)
		{
			return Shader.GetGlobalMatrixArray(Shader.PropertyToID(name));
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0002BC84 File Offset: 0x00029E84
		public static Il2CppStructArray<Matrix4x4> GetGlobalMatrixArray(int nameID)
		{
			return (Shader.GetGlobalMatrixArrayCountImpl(nameID) != 0) ? Shader.GetGlobalMatrixArrayImpl(nameID) : null;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00007480 File Offset: 0x00005680
		public static void GetGlobalFloatArray(string name, List<float> values)
		{
			Shader.ExtractGlobalFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00007490 File Offset: 0x00005690
		public static void GetGlobalFloatArray(int nameID, List<float> values)
		{
			Shader.ExtractGlobalFloatArray(nameID, values);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0000749B File Offset: 0x0000569B
		public static void GetGlobalVectorArray(string name, List<Vector4> values)
		{
			Shader.ExtractGlobalVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000074AB File Offset: 0x000056AB
		public static void GetGlobalVectorArray(int nameID, List<Vector4> values)
		{
			Shader.ExtractGlobalVectorArray(nameID, values);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x000074B6 File Offset: 0x000056B6
		public static void GetGlobalMatrixArray(string name, List<Matrix4x4> values)
		{
			Shader.ExtractGlobalMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x000074C6 File Offset: 0x000056C6
		public static void GetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
		{
			Shader.ExtractGlobalMatrixArray(nameID, values);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0002BCA8 File Offset: 0x00029EA8
		public static string GetPropertyName(Shader shader, int propertyIndex)
		{
			IntPtr intPtr = Shader.GetPropertyNameDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x000074D1 File Offset: 0x000056D1
		public static int GetPropertyNameId(Shader shader, int propertyIndex)
		{
			return Shader.GetPropertyNameIdDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x000074E4 File Offset: 0x000056E4
		public static UnityEngine.Rendering.ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex)
		{
			return Shader.GetPropertyTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0002BCD0 File Offset: 0x00029ED0
		public static string GetPropertyDescription(Shader shader, int propertyIndex)
		{
			IntPtr intPtr = Shader.GetPropertyDescriptionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x000074F7 File Offset: 0x000056F7
		public static UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(Shader shader, int propertyIndex)
		{
			return Shader.GetPropertyFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0002BCF8 File Offset: 0x00029EF8
		public static Il2CppStringArray GetPropertyAttributes(Shader shader, int propertyIndex)
		{
			IntPtr intPtr = Shader.GetPropertyAttributesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0002BD28 File Offset: 0x00029F28
		public static Vector4 GetPropertyDefaultValue(Shader shader, int propertyIndex)
		{
			Vector4 vector;
			Shader.GetPropertyDefaultValue_Injected(shader, propertyIndex, out vector);
			return vector;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0000750A File Offset: 0x0000570A
		public static UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(Shader shader, int propertyIndex)
		{
			return Shader.GetPropertyTextureDimensionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0002BD40 File Offset: 0x00029F40
		public static string GetPropertyTextureDefaultName(Shader shader, int propertyIndex)
		{
			IntPtr intPtr = Shader.GetPropertyTextureDefaultNameDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0002BD68 File Offset: 0x00029F68
		public unsafe static bool FindTextureStackImpl(Shader s, int propertyIdx, out string stackName, out int layerIndex)
		{
			Shader.FindTextureStackImplDelegate findTextureStackImplDelegateField = Shader.FindTextureStackImplDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(stackName);
			return findTextureStackImplDelegateField(intPtr, propertyIdx, &intPtr2, out layerIndex);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0002BD94 File Offset: 0x00029F94
		public static void CheckPropertyIndex(Shader s, int propertyIndex)
		{
			bool flag = propertyIndex < 0 || propertyIndex >= s.GetPropertyCount();
			if (flag)
			{
				throw new ArgumentOutOfRangeException("propertyIndex");
			}
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0000751D File Offset: 0x0000571D
		public int GetPropertyCount()
		{
			return Shader.GetPropertyCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0000752F File Offset: 0x0000572F
		public int FindPropertyIndex(string propertyName)
		{
			return Shader.FindPropertyIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(propertyName));
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0002BDC4 File Offset: 0x00029FC4
		public string GetPropertyName(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyName(this, propertyIndex);
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0002BDE8 File Offset: 0x00029FE8
		public int GetPropertyNameId(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyNameId(this, propertyIndex);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0002BE0C File Offset: 0x0002A00C
		public UnityEngine.Rendering.ShaderPropertyType GetPropertyType(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyType(this, propertyIndex);
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0002BE30 File Offset: 0x0002A030
		public string GetPropertyDescription(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyDescription(this, propertyIndex);
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0002BE54 File Offset: 0x0002A054
		public UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyFlags(this, propertyIndex);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0002BE78 File Offset: 0x0002A078
		public Il2CppStringArray GetPropertyAttributes(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyAttributes(this, propertyIndex);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0002BE9C File Offset: 0x0002A09C
		public float GetPropertyDefaultFloatValue(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			UnityEngine.Rendering.ShaderPropertyType propertyType = this.GetPropertyType(propertyIndex);
			bool flag = propertyType != UnityEngine.Rendering.ShaderPropertyType.Float && propertyType != UnityEngine.Rendering.ShaderPropertyType.Range;
			if (flag)
			{
				throw new ArgumentException("Property type is not Float or Range.");
			}
			return Shader.GetPropertyDefaultValue(this, propertyIndex)[0];
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0002BEEC File Offset: 0x0002A0EC
		public Vector4 GetPropertyDefaultVectorValue(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			UnityEngine.Rendering.ShaderPropertyType propertyType = this.GetPropertyType(propertyIndex);
			bool flag = propertyType != UnityEngine.Rendering.ShaderPropertyType.Color && propertyType != UnityEngine.Rendering.ShaderPropertyType.Vector;
			if (flag)
			{
				throw new ArgumentException("Property type is not Color or Vector.");
			}
			return Shader.GetPropertyDefaultValue(this, propertyIndex);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0002BF34 File Offset: 0x0002A134
		public Vector2 GetPropertyRangeLimits(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			bool flag = this.GetPropertyType(propertyIndex) != UnityEngine.Rendering.ShaderPropertyType.Range;
			if (flag)
			{
				throw new ArgumentException("Property type is not Range.");
			}
			Vector4 propertyDefaultValue = Shader.GetPropertyDefaultValue(this, propertyIndex);
			return new Vector2(propertyDefaultValue[1], propertyDefaultValue[2]);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0002BF88 File Offset: 0x0002A188
		public UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			bool flag = this.GetPropertyType(propertyIndex) != UnityEngine.Rendering.ShaderPropertyType.Texture;
			if (flag)
			{
				throw new ArgumentException("Property type is not TexEnv.");
			}
			return Shader.GetPropertyTextureDimension(this, propertyIndex);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0002BFC8 File Offset: 0x0002A1C8
		public string GetPropertyTextureDefaultName(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			UnityEngine.Rendering.ShaderPropertyType propertyType = this.GetPropertyType(propertyIndex);
			bool flag = propertyType != UnityEngine.Rendering.ShaderPropertyType.Texture;
			if (flag)
			{
				throw new ArgumentException("Property type is not Texture.");
			}
			return Shader.GetPropertyTextureDefaultName(this, propertyIndex);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0002C008 File Offset: 0x0002A208
		public bool FindTextureStack(int propertyIndex, out string stackName, out int layerIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			UnityEngine.Rendering.ShaderPropertyType propertyType = this.GetPropertyType(propertyIndex);
			bool flag = propertyType != UnityEngine.Rendering.ShaderPropertyType.Texture;
			if (flag)
			{
				throw new ArgumentException("Property type is not Texture.");
			}
			return Shader.FindTextureStackImpl(this, propertyIndex, out stackName, out layerIndex);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00007547 File Offset: 0x00005747
		public static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value)
		{
			Shader.SetGlobalMatrixImpl_InjectedDelegateField(name, ref value);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00007555 File Offset: 0x00005755
		public static void GetGlobalVectorImpl_Injected(int name, out Vector4 ret)
		{
			Shader.GetGlobalVectorImpl_InjectedDelegateField(name, out ret);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00007563 File Offset: 0x00005763
		public static void GetGlobalMatrixImpl_Injected(int name, out Matrix4x4 ret)
		{
			Shader.GetGlobalMatrixImpl_InjectedDelegateField(name, out ret);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00007571 File Offset: 0x00005771
		public static void GetPropertyDefaultValue_Injected(Shader shader, int propertyIndex, out Vector4 ret)
		{
			Shader.GetPropertyDefaultValue_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex, out ret);
		}

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_Shader_String_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_get_isSupported_Public_get_Boolean_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_String_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_DisableKeyword_Public_Static_Void_String_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_TagToID_Internal_Static_Int32_String_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_PropertyToID_Public_Static_Int32_String_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloatImpl_Private_Static_Void_Int32_Single_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVectorImpl_Private_Static_Void_Int32_Vector4_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloatArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloatArray_Private_Static_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_Int32_Single_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_String_Vector4_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_Int32_Vector4_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloatArray_Public_Static_Void_Int32_Il2CppStructArray_1_Single_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVectorImpl_Injected_Private_Static_Void_Int32_byref_Vector4_0;

		// Token: 0x04000654 RID: 1620
		private static readonly Shader.FindBuiltinDelegate FindBuiltinDelegateField;

		// Token: 0x04000655 RID: 1621
		private static readonly Shader.get_maximumLODDelegate get_maximumLODDelegateField;

		// Token: 0x04000656 RID: 1622
		private static readonly Shader.set_maximumLODDelegate set_maximumLODDelegateField;

		// Token: 0x04000657 RID: 1623
		private static readonly Shader.get_globalMaximumLODDelegate get_globalMaximumLODDelegateField;

		// Token: 0x04000658 RID: 1624
		private static readonly Shader.set_globalMaximumLODDelegate set_globalMaximumLODDelegateField;

		// Token: 0x04000659 RID: 1625
		private static readonly Shader.get_globalRenderPipelineDelegate get_globalRenderPipelineDelegateField;

		// Token: 0x0400065A RID: 1626
		private static readonly Shader.set_globalRenderPipelineDelegate set_globalRenderPipelineDelegateField;

		// Token: 0x0400065B RID: 1627
		private static readonly Shader.IsKeywordEnabledDelegate IsKeywordEnabledDelegateField;

		// Token: 0x0400065C RID: 1628
		private static readonly Shader.get_renderQueueDelegate get_renderQueueDelegateField;

		// Token: 0x0400065D RID: 1629
		private static readonly Shader.get_disableBatchingDelegate get_disableBatchingDelegateField;

		// Token: 0x0400065E RID: 1630
		private static readonly Shader.WarmupAllShadersDelegate WarmupAllShadersDelegateField;

		// Token: 0x0400065F RID: 1631
		private static readonly Shader.IDToTagDelegate IDToTagDelegateField;

		// Token: 0x04000660 RID: 1632
		private static readonly Shader.GetDependencyDelegate GetDependencyDelegateField;

		// Token: 0x04000661 RID: 1633
		private static readonly Shader.get_passCountDelegate get_passCountDelegateField;

		// Token: 0x04000662 RID: 1634
		private static readonly Shader.Internal_FindPassTagValueDelegate Internal_FindPassTagValueDelegateField;

		// Token: 0x04000663 RID: 1635
		private static readonly Shader.SetGlobalTextureImplDelegate SetGlobalTextureImplDelegateField;

		// Token: 0x04000664 RID: 1636
		private static readonly Shader.SetGlobalRenderTextureImplDelegate SetGlobalRenderTextureImplDelegateField;

		// Token: 0x04000665 RID: 1637
		private static readonly Shader.SetGlobalBufferImplDelegate SetGlobalBufferImplDelegateField;

		// Token: 0x04000666 RID: 1638
		private static readonly Shader.SetGlobalGraphicsBufferImplDelegate SetGlobalGraphicsBufferImplDelegateField;

		// Token: 0x04000667 RID: 1639
		private static readonly Shader.SetGlobalConstantBufferImplDelegate SetGlobalConstantBufferImplDelegateField;

		// Token: 0x04000668 RID: 1640
		private static readonly Shader.SetGlobalConstantGraphicsBufferImplDelegate SetGlobalConstantGraphicsBufferImplDelegateField;

		// Token: 0x04000669 RID: 1641
		private static readonly Shader.GetGlobalFloatImplDelegate GetGlobalFloatImplDelegateField;

		// Token: 0x0400066A RID: 1642
		private static readonly Shader.GetGlobalTextureImplDelegate GetGlobalTextureImplDelegateField;

		// Token: 0x0400066B RID: 1643
		private static readonly Shader.SetGlobalVectorArrayImplDelegate SetGlobalVectorArrayImplDelegateField;

		// Token: 0x0400066C RID: 1644
		private static readonly Shader.SetGlobalMatrixArrayImplDelegate SetGlobalMatrixArrayImplDelegateField;

		// Token: 0x0400066D RID: 1645
		private static readonly Shader.GetGlobalFloatArrayImplDelegate GetGlobalFloatArrayImplDelegateField;

		// Token: 0x0400066E RID: 1646
		private static readonly Shader.GetGlobalVectorArrayImplDelegate GetGlobalVectorArrayImplDelegateField;

		// Token: 0x0400066F RID: 1647
		private static readonly Shader.GetGlobalMatrixArrayImplDelegate GetGlobalMatrixArrayImplDelegateField;

		// Token: 0x04000670 RID: 1648
		private static readonly Shader.GetGlobalFloatArrayCountImplDelegate GetGlobalFloatArrayCountImplDelegateField;

		// Token: 0x04000671 RID: 1649
		private static readonly Shader.GetGlobalVectorArrayCountImplDelegate GetGlobalVectorArrayCountImplDelegateField;

		// Token: 0x04000672 RID: 1650
		private static readonly Shader.GetGlobalMatrixArrayCountImplDelegate GetGlobalMatrixArrayCountImplDelegateField;

		// Token: 0x04000673 RID: 1651
		private static readonly Shader.ExtractGlobalFloatArrayImplDelegate ExtractGlobalFloatArrayImplDelegateField;

		// Token: 0x04000674 RID: 1652
		private static readonly Shader.ExtractGlobalVectorArrayImplDelegate ExtractGlobalVectorArrayImplDelegateField;

		// Token: 0x04000675 RID: 1653
		private static readonly Shader.ExtractGlobalMatrixArrayImplDelegate ExtractGlobalMatrixArrayImplDelegateField;

		// Token: 0x04000676 RID: 1654
		private static readonly Shader.GetPropertyNameDelegate GetPropertyNameDelegateField;

		// Token: 0x04000677 RID: 1655
		private static readonly Shader.GetPropertyNameIdDelegate GetPropertyNameIdDelegateField;

		// Token: 0x04000678 RID: 1656
		private static readonly Shader.GetPropertyTypeDelegate GetPropertyTypeDelegateField;

		// Token: 0x04000679 RID: 1657
		private static readonly Shader.GetPropertyDescriptionDelegate GetPropertyDescriptionDelegateField;

		// Token: 0x0400067A RID: 1658
		private static readonly Shader.GetPropertyFlagsDelegate GetPropertyFlagsDelegateField;

		// Token: 0x0400067B RID: 1659
		private static readonly Shader.GetPropertyAttributesDelegate GetPropertyAttributesDelegateField;

		// Token: 0x0400067C RID: 1660
		private static readonly Shader.GetPropertyTextureDimensionDelegate GetPropertyTextureDimensionDelegateField;

		// Token: 0x0400067D RID: 1661
		private static readonly Shader.GetPropertyTextureDefaultNameDelegate GetPropertyTextureDefaultNameDelegateField;

		// Token: 0x0400067E RID: 1662
		private static readonly Shader.FindTextureStackImplDelegate FindTextureStackImplDelegateField;

		// Token: 0x0400067F RID: 1663
		private static readonly Shader.GetPropertyCountDelegate GetPropertyCountDelegateField;

		// Token: 0x04000680 RID: 1664
		private static readonly Shader.FindPropertyIndexDelegate FindPropertyIndexDelegateField;

		// Token: 0x04000681 RID: 1665
		private static readonly Shader.SetGlobalMatrixImpl_InjectedDelegate SetGlobalMatrixImpl_InjectedDelegateField;

		// Token: 0x04000682 RID: 1666
		private static readonly Shader.GetGlobalVectorImpl_InjectedDelegate GetGlobalVectorImpl_InjectedDelegateField;

		// Token: 0x04000683 RID: 1667
		private static readonly Shader.GetGlobalMatrixImpl_InjectedDelegate GetGlobalMatrixImpl_InjectedDelegateField;

		// Token: 0x04000684 RID: 1668
		private static readonly Shader.GetPropertyDefaultValue_InjectedDelegate GetPropertyDefaultValue_InjectedDelegateField;

		// Token: 0x020005A1 RID: 1441
		// (Invoke) Token: 0x06002978 RID: 10616
		private delegate IntPtr FindBuiltinDelegate(IntPtr name);

		// Token: 0x020005A2 RID: 1442
		// (Invoke) Token: 0x0600297A RID: 10618
		private delegate int get_maximumLODDelegate(IntPtr @this);

		// Token: 0x020005A3 RID: 1443
		// (Invoke) Token: 0x0600297C RID: 10620
		private delegate void set_maximumLODDelegate(IntPtr @this, int value);

		// Token: 0x020005A4 RID: 1444
		// (Invoke) Token: 0x0600297E RID: 10622
		private delegate int get_globalMaximumLODDelegate();

		// Token: 0x020005A5 RID: 1445
		// (Invoke) Token: 0x06002980 RID: 10624
		private delegate void set_globalMaximumLODDelegate(int value);

		// Token: 0x020005A6 RID: 1446
		// (Invoke) Token: 0x06002982 RID: 10626
		private delegate IntPtr get_globalRenderPipelineDelegate();

		// Token: 0x020005A7 RID: 1447
		// (Invoke) Token: 0x06002984 RID: 10628
		private delegate void set_globalRenderPipelineDelegate(IntPtr value);

		// Token: 0x020005A8 RID: 1448
		// (Invoke) Token: 0x06002986 RID: 10630
		private delegate bool IsKeywordEnabledDelegate(IntPtr keyword);

		// Token: 0x020005A9 RID: 1449
		// (Invoke) Token: 0x06002988 RID: 10632
		private delegate int get_renderQueueDelegate(IntPtr @this);

		// Token: 0x020005AA RID: 1450
		// (Invoke) Token: 0x0600298A RID: 10634
		private delegate DisableBatchingType get_disableBatchingDelegate(IntPtr @this);

		// Token: 0x020005AB RID: 1451
		// (Invoke) Token: 0x0600298C RID: 10636
		private delegate void WarmupAllShadersDelegate();

		// Token: 0x020005AC RID: 1452
		// (Invoke) Token: 0x0600298E RID: 10638
		private delegate IntPtr IDToTagDelegate(int name);

		// Token: 0x020005AD RID: 1453
		// (Invoke) Token: 0x06002990 RID: 10640
		private delegate IntPtr GetDependencyDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020005AE RID: 1454
		// (Invoke) Token: 0x06002992 RID: 10642
		private delegate int get_passCountDelegate(IntPtr @this);

		// Token: 0x020005AF RID: 1455
		// (Invoke) Token: 0x06002994 RID: 10644
		private delegate int Internal_FindPassTagValueDelegate(IntPtr @this, int passIndex, int tagName);

		// Token: 0x020005B0 RID: 1456
		// (Invoke) Token: 0x06002996 RID: 10646
		private delegate void SetGlobalTextureImplDelegate(int name, IntPtr value);

		// Token: 0x020005B1 RID: 1457
		// (Invoke) Token: 0x06002998 RID: 10648
		private delegate void SetGlobalRenderTextureImplDelegate(int name, IntPtr value, UnityEngine.Rendering.RenderTextureSubElement element);

		// Token: 0x020005B2 RID: 1458
		// (Invoke) Token: 0x0600299A RID: 10650
		private delegate void SetGlobalBufferImplDelegate(int name, IntPtr value);

		// Token: 0x020005B3 RID: 1459
		// (Invoke) Token: 0x0600299C RID: 10652
		private delegate void SetGlobalGraphicsBufferImplDelegate(int name, IntPtr value);

		// Token: 0x020005B4 RID: 1460
		// (Invoke) Token: 0x0600299E RID: 10654
		private delegate void SetGlobalConstantBufferImplDelegate(int name, IntPtr value, int offset, int size);

		// Token: 0x020005B5 RID: 1461
		// (Invoke) Token: 0x060029A0 RID: 10656
		private delegate void SetGlobalConstantGraphicsBufferImplDelegate(int name, IntPtr value, int offset, int size);

		// Token: 0x020005B6 RID: 1462
		// (Invoke) Token: 0x060029A2 RID: 10658
		private delegate float GetGlobalFloatImplDelegate(int name);

		// Token: 0x020005B7 RID: 1463
		// (Invoke) Token: 0x060029A4 RID: 10660
		private delegate IntPtr GetGlobalTextureImplDelegate(int name);

		// Token: 0x020005B8 RID: 1464
		// (Invoke) Token: 0x060029A6 RID: 10662
		private delegate void SetGlobalVectorArrayImplDelegate(int name, IntPtr values, int count);

		// Token: 0x020005B9 RID: 1465
		// (Invoke) Token: 0x060029A8 RID: 10664
		private delegate void SetGlobalMatrixArrayImplDelegate(int name, IntPtr values, int count);

		// Token: 0x020005BA RID: 1466
		// (Invoke) Token: 0x060029AA RID: 10666
		private delegate IntPtr GetGlobalFloatArrayImplDelegate(int name);

		// Token: 0x020005BB RID: 1467
		// (Invoke) Token: 0x060029AC RID: 10668
		private delegate IntPtr GetGlobalVectorArrayImplDelegate(int name);

		// Token: 0x020005BC RID: 1468
		// (Invoke) Token: 0x060029AE RID: 10670
		private delegate IntPtr GetGlobalMatrixArrayImplDelegate(int name);

		// Token: 0x020005BD RID: 1469
		// (Invoke) Token: 0x060029B0 RID: 10672
		private delegate int GetGlobalFloatArrayCountImplDelegate(int name);

		// Token: 0x020005BE RID: 1470
		// (Invoke) Token: 0x060029B2 RID: 10674
		private delegate int GetGlobalVectorArrayCountImplDelegate(int name);

		// Token: 0x020005BF RID: 1471
		// (Invoke) Token: 0x060029B4 RID: 10676
		private delegate int GetGlobalMatrixArrayCountImplDelegate(int name);

		// Token: 0x020005C0 RID: 1472
		// (Invoke) Token: 0x060029B6 RID: 10678
		private delegate void ExtractGlobalFloatArrayImplDelegate(int name, [Out] IntPtr val);

		// Token: 0x020005C1 RID: 1473
		// (Invoke) Token: 0x060029B8 RID: 10680
		private delegate void ExtractGlobalVectorArrayImplDelegate(int name, [Out] IntPtr val);

		// Token: 0x020005C2 RID: 1474
		// (Invoke) Token: 0x060029BA RID: 10682
		private delegate void ExtractGlobalMatrixArrayImplDelegate(int name, [Out] IntPtr val);

		// Token: 0x020005C3 RID: 1475
		// (Invoke) Token: 0x060029BC RID: 10684
		private delegate IntPtr GetPropertyNameDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020005C4 RID: 1476
		// (Invoke) Token: 0x060029BE RID: 10686
		private delegate int GetPropertyNameIdDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020005C5 RID: 1477
		// (Invoke) Token: 0x060029C0 RID: 10688
		private delegate UnityEngine.Rendering.ShaderPropertyType GetPropertyTypeDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020005C6 RID: 1478
		// (Invoke) Token: 0x060029C2 RID: 10690
		private delegate IntPtr GetPropertyDescriptionDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020005C7 RID: 1479
		// (Invoke) Token: 0x060029C4 RID: 10692
		private delegate UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlagsDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020005C8 RID: 1480
		// (Invoke) Token: 0x060029C6 RID: 10694
		private delegate IntPtr GetPropertyAttributesDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020005C9 RID: 1481
		// (Invoke) Token: 0x060029C8 RID: 10696
		private delegate UnityEngine.Rendering.TextureDimension GetPropertyTextureDimensionDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020005CA RID: 1482
		// (Invoke) Token: 0x060029CA RID: 10698
		private delegate IntPtr GetPropertyTextureDefaultNameDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020005CB RID: 1483
		// (Invoke) Token: 0x060029CC RID: 10700
		private delegate bool FindTextureStackImplDelegate(IntPtr s, int propertyIdx, [Out] IntPtr stackName, [Out] IntPtr layerIndex);

		// Token: 0x020005CC RID: 1484
		// (Invoke) Token: 0x060029CE RID: 10702
		private delegate int GetPropertyCountDelegate(IntPtr @this);

		// Token: 0x020005CD RID: 1485
		// (Invoke) Token: 0x060029D0 RID: 10704
		private delegate int FindPropertyIndexDelegate(IntPtr @this, IntPtr propertyName);

		// Token: 0x020005CE RID: 1486
		// (Invoke) Token: 0x060029D2 RID: 10706
		private delegate void SetGlobalMatrixImpl_InjectedDelegate(int name, IntPtr value);

		// Token: 0x020005CF RID: 1487
		// (Invoke) Token: 0x060029D4 RID: 10708
		private delegate void GetGlobalVectorImpl_InjectedDelegate(int name, [Out] IntPtr ret);

		// Token: 0x020005D0 RID: 1488
		// (Invoke) Token: 0x060029D6 RID: 10710
		private delegate void GetGlobalMatrixImpl_InjectedDelegate(int name, [Out] IntPtr ret);

		// Token: 0x020005D1 RID: 1489
		// (Invoke) Token: 0x060029D8 RID: 10712
		private delegate void GetPropertyDefaultValue_InjectedDelegate(IntPtr shader, int propertyIndex, [Out] IntPtr ret);
	}
}
