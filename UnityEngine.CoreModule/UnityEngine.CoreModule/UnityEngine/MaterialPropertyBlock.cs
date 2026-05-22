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
	// Token: 0x0200006E RID: 110
	public sealed class MaterialPropertyBlock : Object
	{
		// Token: 0x06000811 RID: 2065 RVA: 0x00028AAC File Offset: 0x00026CAC
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialPropertyBlock()
		{
			Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MaterialPropertyBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr);
			MaterialPropertyBlock.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, "m_Ptr");
			MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663851);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Private_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663852);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663853);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663854);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663855);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetBufferImpl_Private_Void_Int32_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663856);
			MaterialPropertyBlock.NativeMethodInfoPtr_CreateImpl_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663857);
			MaterialPropertyBlock.NativeMethodInfoPtr_DestroyImpl_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663858);
			MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663859);
			MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663860);
			MaterialPropertyBlock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663861);
			MaterialPropertyBlock.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663862);
			MaterialPropertyBlock.NativeMethodInfoPtr_Dispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663863);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663864);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663865);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663866);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663867);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663868);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663869);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663870);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Injected_Private_Void_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663871);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetColorImpl_Injected_Private_Void_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663872);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100663873);
			MaterialPropertyBlock.GetFloatImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetFloatImplDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatImpl");
			MaterialPropertyBlock.GetTextureImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetTextureImplDelegate>("UnityEngine.MaterialPropertyBlock::GetTextureImpl");
			MaterialPropertyBlock.SetRenderTextureImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetRenderTextureImplDelegate>("UnityEngine.MaterialPropertyBlock::SetRenderTextureImpl");
			MaterialPropertyBlock.SetGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetGraphicsBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::SetGraphicsBufferImpl");
			MaterialPropertyBlock.SetConstantBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetConstantBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::SetConstantBufferImpl");
			MaterialPropertyBlock.SetConstantGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetConstantGraphicsBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::SetConstantGraphicsBufferImpl");
			MaterialPropertyBlock.SetFloatArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetFloatArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::SetFloatArrayImpl");
			MaterialPropertyBlock.SetVectorArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetVectorArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::SetVectorArrayImpl");
			MaterialPropertyBlock.SetMatrixArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetMatrixArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::SetMatrixArrayImpl");
			MaterialPropertyBlock.GetFloatArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetFloatArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatArrayImpl");
			MaterialPropertyBlock.GetVectorArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetVectorArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorArrayImpl");
			MaterialPropertyBlock.GetMatrixArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetMatrixArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixArrayImpl");
			MaterialPropertyBlock.GetFloatArrayCountImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetFloatArrayCountImplDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatArrayCountImpl");
			MaterialPropertyBlock.GetVectorArrayCountImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetVectorArrayCountImplDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorArrayCountImpl");
			MaterialPropertyBlock.GetMatrixArrayCountImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetMatrixArrayCountImplDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixArrayCountImpl");
			MaterialPropertyBlock.ExtractFloatArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ExtractFloatArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::ExtractFloatArrayImpl");
			MaterialPropertyBlock.ExtractVectorArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ExtractVectorArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::ExtractVectorArrayImpl");
			MaterialPropertyBlock.ExtractMatrixArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ExtractMatrixArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::ExtractMatrixArrayImpl");
			MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFromDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFromDelegate>("UnityEngine.MaterialPropertyBlock::Internal_CopyProbeOcclusionArrayFrom");
			MaterialPropertyBlock.get_isEmptyDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.get_isEmptyDelegate>("UnityEngine.MaterialPropertyBlock::get_isEmpty");
			MaterialPropertyBlock.GetVectorImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetVectorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorImpl_Injected");
			MaterialPropertyBlock.GetColorImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetColorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetColorImpl_Injected");
			MaterialPropertyBlock.GetMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetMatrixImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixImpl_Injected");
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00028E18 File Offset: 0x00027018
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 488227, RefRangeEnd = 488239, XrefRangeStart = 488223, XrefRangeEnd = 488227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00028E64 File Offset: 0x00027064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488239, XrefRangeEnd = 488241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorImpl(int name, Vector4 value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Private_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00028EB0 File Offset: 0x000270B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488241, XrefRangeEnd = 488243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00028EFC File Offset: 0x000270FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488243, XrefRangeEnd = 488245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00028F48 File Offset: 0x00027148
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 488249, RefRangeEnd = 488256, XrefRangeStart = 488245, XrefRangeEnd = 488249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00028F98 File Offset: 0x00027198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488256, XrefRangeEnd = 488260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBufferImpl(int name, ComputeBuffer value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetBufferImpl_Private_Void_Int32_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00028FE8 File Offset: 0x000271E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488260, XrefRangeEnd = 488264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateImpl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_CreateImpl_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00029018 File Offset: 0x00027218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488264, XrefRangeEnd = 488268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyImpl(IntPtr mpb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mpb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_DestroyImpl_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0002904C File Offset: 0x0002724C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488268, XrefRangeEnd = 488272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(bool keepMemory)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keepMemory;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0002908C File Offset: 0x0002728C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488272, XrefRangeEnd = 488276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x000290C0 File Offset: 0x000272C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488276, XrefRangeEnd = 488278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialPropertyBlock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000290FC File Offset: 0x000272FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488278, XrefRangeEnd = 488286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00029130 File Offset: 0x00027330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488286, XrefRangeEnd = 488295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Dispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00029164 File Offset: 0x00027364
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 488227, RefRangeEnd = 488239, XrefRangeStart = 488227, XrefRangeEnd = 488239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000291B0 File Offset: 0x000273B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488297, RefRangeEnd = 488299, XrefRangeStart = 488295, XrefRangeEnd = 488297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x000291FC File Offset: 0x000273FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488299, XrefRangeEnd = 488301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00029248 File Offset: 0x00027448
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 488303, RefRangeEnd = 488307, XrefRangeStart = 488301, XrefRangeEnd = 488303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00029294 File Offset: 0x00027494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBuffer(int nameID, ComputeBuffer value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000292E4 File Offset: 0x000274E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488315, RefRangeEnd = 488317, XrefRangeStart = 488307, XrefRangeEnd = 488315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00029338 File Offset: 0x00027538
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 488249, RefRangeEnd = 488256, XrefRangeStart = 488249, XrefRangeEnd = 488256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00029388 File Offset: 0x00027588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488317, XrefRangeEnd = 488321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorImpl_Injected(int name, ref Vector4 value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Injected_Private_Void_Int32_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000293D4 File Offset: 0x000275D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488321, XrefRangeEnd = 488325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetColorImpl_Injected_Private_Void_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00029420 File Offset: 0x00027620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488325, XrefRangeEnd = 488329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00006566 File Offset: 0x00004766
		public MaterialPropertyBlock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x0002946C File Offset: 0x0002766C
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x0000656F File Offset: 0x0000476F
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPropertyBlock.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPropertyBlock.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0000658A File Offset: 0x0000478A
		public void AddFloat(string name, float value)
		{
			this.SetFloat(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0000659B File Offset: 0x0000479B
		public void AddFloat(int nameID, float value)
		{
			this.SetFloat(nameID, value);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x000065A7 File Offset: 0x000047A7
		public void AddVector(string name, Vector4 value)
		{
			this.SetVector(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x000065B8 File Offset: 0x000047B8
		public void AddVector(int nameID, Vector4 value)
		{
			this.SetVector(nameID, value);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000065C4 File Offset: 0x000047C4
		public void AddColor(string name, Color value)
		{
			this.SetColor(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000065D5 File Offset: 0x000047D5
		public void AddColor(int nameID, Color value)
		{
			this.SetColor(nameID, value);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x000065E1 File Offset: 0x000047E1
		public void AddMatrix(string name, Matrix4x4 value)
		{
			this.SetMatrix(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x000065F2 File Offset: 0x000047F2
		public void AddMatrix(int nameID, Matrix4x4 value)
		{
			this.SetMatrix(nameID, value);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x000065FE File Offset: 0x000047FE
		public void AddTexture(string name, Texture value)
		{
			this.SetTexture(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0000660F File Offset: 0x0000480F
		public void AddTexture(int nameID, Texture value)
		{
			this.SetTexture(nameID, value);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0000661B File Offset: 0x0000481B
		public float GetFloatImpl(int name)
		{
			return MaterialPropertyBlock.GetFloatImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00029494 File Offset: 0x00027694
		public Vector4 GetVectorImpl(int name)
		{
			Vector4 vector;
			this.GetVectorImpl_Injected(name, out vector);
			return vector;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000294AC File Offset: 0x000276AC
		public Color GetColorImpl(int name)
		{
			Color color;
			this.GetColorImpl_Injected(name, out color);
			return color;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000294C4 File Offset: 0x000276C4
		public Matrix4x4 GetMatrixImpl(int name)
		{
			Matrix4x4 matrix4x;
			this.GetMatrixImpl_Injected(name, out matrix4x);
			return matrix4x;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x000294DC File Offset: 0x000276DC
		public Texture GetTextureImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetTextureImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0000662E File Offset: 0x0000482E
		public void SetRenderTextureImpl(int name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			MaterialPropertyBlock.SetRenderTextureImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), element);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00006648 File Offset: 0x00004848
		public void SetGraphicsBufferImpl(int name, GraphicsBuffer value)
		{
			MaterialPropertyBlock.SetGraphicsBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00006661 File Offset: 0x00004861
		public void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
		{
			MaterialPropertyBlock.SetConstantBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0000667D File Offset: 0x0000487D
		public void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size)
		{
			MaterialPropertyBlock.SetConstantGraphicsBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00006699 File Offset: 0x00004899
		public void SetFloatArrayImpl(int name, Il2CppStructArray<float> values, int count)
		{
			MaterialPropertyBlock.SetFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000066B3 File Offset: 0x000048B3
		public void SetVectorArrayImpl(int name, Il2CppStructArray<Vector4> values, int count)
		{
			MaterialPropertyBlock.SetVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x000066CD File Offset: 0x000048CD
		public void SetMatrixArrayImpl(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			MaterialPropertyBlock.SetMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0002950C File Offset: 0x0002770C
		public Il2CppStructArray<float> GetFloatArrayImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0002953C File Offset: 0x0002773C
		public Il2CppStructArray<Vector4> GetVectorArrayImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0002956C File Offset: 0x0002776C
		public Il2CppStructArray<Matrix4x4> GetMatrixArrayImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x000066E7 File Offset: 0x000048E7
		public int GetFloatArrayCountImpl(int name)
		{
			return MaterialPropertyBlock.GetFloatArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x000066FA File Offset: 0x000048FA
		public int GetVectorArrayCountImpl(int name)
		{
			return MaterialPropertyBlock.GetVectorArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0000670D File Offset: 0x0000490D
		public int GetMatrixArrayCountImpl(int name)
		{
			return MaterialPropertyBlock.GetMatrixArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00006720 File Offset: 0x00004920
		public void ExtractFloatArrayImpl(int name, [Out] Il2CppStructArray<float> val)
		{
			MaterialPropertyBlock.ExtractFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00006739 File Offset: 0x00004939
		public void ExtractVectorArrayImpl(int name, [Out] Il2CppStructArray<Vector4> val)
		{
			MaterialPropertyBlock.ExtractVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00006752 File Offset: 0x00004952
		public void ExtractMatrixArrayImpl(int name, [Out] Il2CppStructArray<Matrix4x4> val)
		{
			MaterialPropertyBlock.ExtractMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0000676B File Offset: 0x0000496B
		public static void Internal_CopyProbeOcclusionArrayFrom(MaterialPropertyBlock properties, Il2CppStructArray<Vector4> occlusionProbes, int sourceStart, int destStart, int count)
		{
			MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFromDelegateField(IL2CPP.Il2CppObjectBaseToPtr(properties), IL2CPP.Il2CppObjectBaseToPtr(occlusionProbes), sourceStart, destStart, count);
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00006787 File Offset: 0x00004987
		public bool isEmpty
		{
			get
			{
				return MaterialPropertyBlock.get_isEmptyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0002959C File Offset: 0x0002779C
		public void SetFloatArray(int name, Il2CppStructArray<float> values, int count)
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
			this.SetFloatArrayImpl(name, values, count);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x000295F8 File Offset: 0x000277F8
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

		// Token: 0x0600084F RID: 2127 RVA: 0x00029654 File Offset: 0x00027854
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

		// Token: 0x06000850 RID: 2128 RVA: 0x000296B0 File Offset: 0x000278B0
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

		// Token: 0x06000851 RID: 2129 RVA: 0x00029708 File Offset: 0x00027908
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

		// Token: 0x06000852 RID: 2130 RVA: 0x00029760 File Offset: 0x00027960
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

		// Token: 0x06000853 RID: 2131 RVA: 0x00006799 File Offset: 0x00004999
		public void SetFloat(string name, float value)
		{
			this.SetFloatImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000067AA File Offset: 0x000049AA
		public void SetInt(string name, int value)
		{
			this.SetFloatImpl(Shader.PropertyToID(name), (float)value);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000067BC File Offset: 0x000049BC
		public void SetInt(int nameID, int value)
		{
			this.SetFloatImpl(nameID, (float)value);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x000067C9 File Offset: 0x000049C9
		public void SetVector(string name, Vector4 value)
		{
			this.SetVectorImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000067DA File Offset: 0x000049DA
		public void SetColor(string name, Color value)
		{
			this.SetColorImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000067EB File Offset: 0x000049EB
		public void SetMatrix(string name, Matrix4x4 value)
		{
			this.SetMatrixImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000067FC File Offset: 0x000049FC
		public void SetBuffer(string name, ComputeBuffer value)
		{
			this.SetBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0000680D File Offset: 0x00004A0D
		public void SetBuffer(string name, GraphicsBuffer value)
		{
			this.SetGraphicsBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0000681E File Offset: 0x00004A1E
		public void SetBuffer(int nameID, GraphicsBuffer value)
		{
			this.SetGraphicsBufferImpl(nameID, value);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0000682A File Offset: 0x00004A2A
		public void SetTexture(string name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTextureImpl(Shader.PropertyToID(name), value, element);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0000683C File Offset: 0x00004A3C
		public void SetTexture(int nameID, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTextureImpl(nameID, value, element);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00006849 File Offset: 0x00004A49
		public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size)
		{
			this.SetConstantBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0000685D File Offset: 0x00004A5D
		public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
		{
			this.SetConstantBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0000686C File Offset: 0x00004A6C
		public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size)
		{
			this.SetConstantGraphicsBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00006880 File Offset: 0x00004A80
		public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size)
		{
			this.SetConstantGraphicsBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0000688F File Offset: 0x00004A8F
		public void SetFloatArray(string name, List<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000068AB File Offset: 0x00004AAB
		public void SetFloatArray(int nameID, List<float> values)
		{
			this.SetFloatArray(nameID, NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000068C2 File Offset: 0x00004AC2
		public void SetFloatArray(string name, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x000068DA File Offset: 0x00004ADA
		public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(nameID, values, values.Length);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000068ED File Offset: 0x00004AED
		public void SetVectorArray(string name, List<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00006909 File Offset: 0x00004B09
		public void SetVectorArray(int nameID, List<Vector4> values)
		{
			this.SetVectorArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00006920 File Offset: 0x00004B20
		public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00006938 File Offset: 0x00004B38
		public void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(nameID, values, values.Length);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0000694B File Offset: 0x00004B4B
		public void SetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00006967 File Offset: 0x00004B67
		public void SetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.SetMatrixArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0000697E File Offset: 0x00004B7E
		public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00006996 File Offset: 0x00004B96
		public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(nameID, values, values.Length);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000297B8 File Offset: 0x000279B8
		public float GetFloat(string name)
		{
			return this.GetFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x000297D8 File Offset: 0x000279D8
		public float GetFloat(int nameID)
		{
			return this.GetFloatImpl(nameID);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x000297F4 File Offset: 0x000279F4
		public int GetInt(string name)
		{
			return (int)this.GetFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00029814 File Offset: 0x00027A14
		public int GetInt(int nameID)
		{
			return (int)this.GetFloatImpl(nameID);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00029830 File Offset: 0x00027A30
		public Vector4 GetVector(string name)
		{
			return this.GetVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00029850 File Offset: 0x00027A50
		public Vector4 GetVector(int nameID)
		{
			return this.GetVectorImpl(nameID);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0002986C File Offset: 0x00027A6C
		public Color GetColor(string name)
		{
			return this.GetColorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0002988C File Offset: 0x00027A8C
		public Color GetColor(int nameID)
		{
			return this.GetColorImpl(nameID);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000298A8 File Offset: 0x00027AA8
		public Matrix4x4 GetMatrix(string name)
		{
			return this.GetMatrixImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000298C8 File Offset: 0x00027AC8
		public Matrix4x4 GetMatrix(int nameID)
		{
			return this.GetMatrixImpl(nameID);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000298E4 File Offset: 0x00027AE4
		public Texture GetTexture(string name)
		{
			return this.GetTextureImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00029904 File Offset: 0x00027B04
		public Texture GetTexture(int nameID)
		{
			return this.GetTextureImpl(nameID);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00029920 File Offset: 0x00027B20
		public Il2CppStructArray<float> GetFloatArray(string name)
		{
			return this.GetFloatArray(Shader.PropertyToID(name));
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00029940 File Offset: 0x00027B40
		public Il2CppStructArray<float> GetFloatArray(int nameID)
		{
			return (this.GetFloatArrayCountImpl(nameID) != 0) ? this.GetFloatArrayImpl(nameID) : null;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00029968 File Offset: 0x00027B68
		public Il2CppStructArray<Vector4> GetVectorArray(string name)
		{
			return this.GetVectorArray(Shader.PropertyToID(name));
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00029988 File Offset: 0x00027B88
		public Il2CppStructArray<Vector4> GetVectorArray(int nameID)
		{
			return (this.GetVectorArrayCountImpl(nameID) != 0) ? this.GetVectorArrayImpl(nameID) : null;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x000299B0 File Offset: 0x00027BB0
		public Il2CppStructArray<Matrix4x4> GetMatrixArray(string name)
		{
			return this.GetMatrixArray(Shader.PropertyToID(name));
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000299D0 File Offset: 0x00027BD0
		public Il2CppStructArray<Matrix4x4> GetMatrixArray(int nameID)
		{
			return (this.GetMatrixArrayCountImpl(nameID) != 0) ? this.GetMatrixArrayImpl(nameID) : null;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x000069A9 File Offset: 0x00004BA9
		public void GetFloatArray(string name, List<float> values)
		{
			this.ExtractFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x000069BA File Offset: 0x00004BBA
		public void GetFloatArray(int nameID, List<float> values)
		{
			this.ExtractFloatArray(nameID, values);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x000069C6 File Offset: 0x00004BC6
		public void GetVectorArray(string name, List<Vector4> values)
		{
			this.ExtractVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000069D7 File Offset: 0x00004BD7
		public void GetVectorArray(int nameID, List<Vector4> values)
		{
			this.ExtractVectorArray(nameID, values);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x000069E3 File Offset: 0x00004BE3
		public void GetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.ExtractMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000069F4 File Offset: 0x00004BF4
		public void GetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.ExtractMatrixArray(nameID, values);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000299F8 File Offset: 0x00027BF8
		public void CopyProbeOcclusionArrayFrom(List<Vector4> occlusionProbes)
		{
			bool flag = occlusionProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("occlusionProbes");
			}
			this.CopyProbeOcclusionArrayFrom(NoAllocHelpers.ExtractArrayFromListT<Vector4>(occlusionProbes), 0, 0, occlusionProbes.Count);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00029A30 File Offset: 0x00027C30
		public void CopyProbeOcclusionArrayFrom(Il2CppStructArray<Vector4> occlusionProbes)
		{
			bool flag = occlusionProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("occlusionProbes");
			}
			this.CopyProbeOcclusionArrayFrom(occlusionProbes, 0, 0, occlusionProbes.Length);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00006A00 File Offset: 0x00004C00
		public void CopyProbeOcclusionArrayFrom(List<Vector4> occlusionProbes, int sourceStart, int destStart, int count)
		{
			this.CopyProbeOcclusionArrayFrom(NoAllocHelpers.ExtractArrayFromListT<Vector4>(occlusionProbes), sourceStart, destStart, count);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00029A64 File Offset: 0x00027C64
		public void CopyProbeOcclusionArrayFrom(Il2CppStructArray<Vector4> occlusionProbes, int sourceStart, int destStart, int count)
		{
			bool flag = occlusionProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("occlusionProbes");
			}
			bool flag2 = sourceStart < 0;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("sourceStart", "Argument sourceStart must not be negative.");
			}
			bool flag3 = destStart < 0;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("sourceStart", "Argument destStart must not be negative.");
			}
			bool flag4 = count < 0;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("count", "Argument count must not be negative.");
			}
			bool flag5 = occlusionProbes.Length < sourceStart + count;
			if (flag5)
			{
				throw new ArgumentOutOfRangeException("The specified source start index or count is out of the range.");
			}
			MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFrom(this, occlusionProbes, sourceStart, destStart, count);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00006A14 File Offset: 0x00004C14
		public void GetVectorImpl_Injected(int name, out Vector4 ret)
		{
			MaterialPropertyBlock.GetVectorImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00006A28 File Offset: 0x00004C28
		public void GetColorImpl_Injected(int name, out Color ret)
		{
			MaterialPropertyBlock.GetColorImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00006A3C File Offset: 0x00004C3C
		public void GetMatrixImpl_Injected(int name, out Matrix4x4 ret)
		{
			MaterialPropertyBlock.GetMatrixImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorImpl_Private_Void_Int32_Vector4_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_SetBufferImpl_Private_Void_Int32_ComputeBuffer_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_CreateImpl_Private_Static_IntPtr_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_DestroyImpl_Private_Static_Void_IntPtr_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_Boolean_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_ComputeBuffer_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorImpl_Injected_Private_Void_Int32_byref_Vector4_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_SetColorImpl_Injected_Private_Void_Int32_byref_Color_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly MaterialPropertyBlock.GetFloatImplDelegate GetFloatImplDelegateField;

		// Token: 0x040005B5 RID: 1461
		private static readonly MaterialPropertyBlock.GetTextureImplDelegate GetTextureImplDelegateField;

		// Token: 0x040005B6 RID: 1462
		private static readonly MaterialPropertyBlock.SetRenderTextureImplDelegate SetRenderTextureImplDelegateField;

		// Token: 0x040005B7 RID: 1463
		private static readonly MaterialPropertyBlock.SetGraphicsBufferImplDelegate SetGraphicsBufferImplDelegateField;

		// Token: 0x040005B8 RID: 1464
		private static readonly MaterialPropertyBlock.SetConstantBufferImplDelegate SetConstantBufferImplDelegateField;

		// Token: 0x040005B9 RID: 1465
		private static readonly MaterialPropertyBlock.SetConstantGraphicsBufferImplDelegate SetConstantGraphicsBufferImplDelegateField;

		// Token: 0x040005BA RID: 1466
		private static readonly MaterialPropertyBlock.SetFloatArrayImplDelegate SetFloatArrayImplDelegateField;

		// Token: 0x040005BB RID: 1467
		private static readonly MaterialPropertyBlock.SetVectorArrayImplDelegate SetVectorArrayImplDelegateField;

		// Token: 0x040005BC RID: 1468
		private static readonly MaterialPropertyBlock.SetMatrixArrayImplDelegate SetMatrixArrayImplDelegateField;

		// Token: 0x040005BD RID: 1469
		private static readonly MaterialPropertyBlock.GetFloatArrayImplDelegate GetFloatArrayImplDelegateField;

		// Token: 0x040005BE RID: 1470
		private static readonly MaterialPropertyBlock.GetVectorArrayImplDelegate GetVectorArrayImplDelegateField;

		// Token: 0x040005BF RID: 1471
		private static readonly MaterialPropertyBlock.GetMatrixArrayImplDelegate GetMatrixArrayImplDelegateField;

		// Token: 0x040005C0 RID: 1472
		private static readonly MaterialPropertyBlock.GetFloatArrayCountImplDelegate GetFloatArrayCountImplDelegateField;

		// Token: 0x040005C1 RID: 1473
		private static readonly MaterialPropertyBlock.GetVectorArrayCountImplDelegate GetVectorArrayCountImplDelegateField;

		// Token: 0x040005C2 RID: 1474
		private static readonly MaterialPropertyBlock.GetMatrixArrayCountImplDelegate GetMatrixArrayCountImplDelegateField;

		// Token: 0x040005C3 RID: 1475
		private static readonly MaterialPropertyBlock.ExtractFloatArrayImplDelegate ExtractFloatArrayImplDelegateField;

		// Token: 0x040005C4 RID: 1476
		private static readonly MaterialPropertyBlock.ExtractVectorArrayImplDelegate ExtractVectorArrayImplDelegateField;

		// Token: 0x040005C5 RID: 1477
		private static readonly MaterialPropertyBlock.ExtractMatrixArrayImplDelegate ExtractMatrixArrayImplDelegateField;

		// Token: 0x040005C6 RID: 1478
		private static readonly MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFromDelegate Internal_CopyProbeOcclusionArrayFromDelegateField;

		// Token: 0x040005C7 RID: 1479
		private static readonly MaterialPropertyBlock.get_isEmptyDelegate get_isEmptyDelegateField;

		// Token: 0x040005C8 RID: 1480
		private static readonly MaterialPropertyBlock.GetVectorImpl_InjectedDelegate GetVectorImpl_InjectedDelegateField;

		// Token: 0x040005C9 RID: 1481
		private static readonly MaterialPropertyBlock.GetColorImpl_InjectedDelegate GetColorImpl_InjectedDelegateField;

		// Token: 0x040005CA RID: 1482
		private static readonly MaterialPropertyBlock.GetMatrixImpl_InjectedDelegate GetMatrixImpl_InjectedDelegateField;

		// Token: 0x02000532 RID: 1330
		// (Invoke) Token: 0x0600289A RID: 10394
		private delegate float GetFloatImplDelegate(IntPtr @this, int name);

		// Token: 0x02000533 RID: 1331
		// (Invoke) Token: 0x0600289C RID: 10396
		private delegate IntPtr GetTextureImplDelegate(IntPtr @this, int name);

		// Token: 0x02000534 RID: 1332
		// (Invoke) Token: 0x0600289E RID: 10398
		private delegate void SetRenderTextureImplDelegate(IntPtr @this, int name, IntPtr value, UnityEngine.Rendering.RenderTextureSubElement element);

		// Token: 0x02000535 RID: 1333
		// (Invoke) Token: 0x060028A0 RID: 10400
		private delegate void SetGraphicsBufferImplDelegate(IntPtr @this, int name, IntPtr value);

		// Token: 0x02000536 RID: 1334
		// (Invoke) Token: 0x060028A2 RID: 10402
		private delegate void SetConstantBufferImplDelegate(IntPtr @this, int name, IntPtr value, int offset, int size);

		// Token: 0x02000537 RID: 1335
		// (Invoke) Token: 0x060028A4 RID: 10404
		private delegate void SetConstantGraphicsBufferImplDelegate(IntPtr @this, int name, IntPtr value, int offset, int size);

		// Token: 0x02000538 RID: 1336
		// (Invoke) Token: 0x060028A6 RID: 10406
		private delegate void SetFloatArrayImplDelegate(IntPtr @this, int name, IntPtr values, int count);

		// Token: 0x02000539 RID: 1337
		// (Invoke) Token: 0x060028A8 RID: 10408
		private delegate void SetVectorArrayImplDelegate(IntPtr @this, int name, IntPtr values, int count);

		// Token: 0x0200053A RID: 1338
		// (Invoke) Token: 0x060028AA RID: 10410
		private delegate void SetMatrixArrayImplDelegate(IntPtr @this, int name, IntPtr values, int count);

		// Token: 0x0200053B RID: 1339
		// (Invoke) Token: 0x060028AC RID: 10412
		private delegate IntPtr GetFloatArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x0200053C RID: 1340
		// (Invoke) Token: 0x060028AE RID: 10414
		private delegate IntPtr GetVectorArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x0200053D RID: 1341
		// (Invoke) Token: 0x060028B0 RID: 10416
		private delegate IntPtr GetMatrixArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x0200053E RID: 1342
		// (Invoke) Token: 0x060028B2 RID: 10418
		private delegate int GetFloatArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x0200053F RID: 1343
		// (Invoke) Token: 0x060028B4 RID: 10420
		private delegate int GetVectorArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x02000540 RID: 1344
		// (Invoke) Token: 0x060028B6 RID: 10422
		private delegate int GetMatrixArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x02000541 RID: 1345
		// (Invoke) Token: 0x060028B8 RID: 10424
		private delegate void ExtractFloatArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x02000542 RID: 1346
		// (Invoke) Token: 0x060028BA RID: 10426
		private delegate void ExtractVectorArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x02000543 RID: 1347
		// (Invoke) Token: 0x060028BC RID: 10428
		private delegate void ExtractMatrixArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x02000544 RID: 1348
		// (Invoke) Token: 0x060028BE RID: 10430
		private delegate void Internal_CopyProbeOcclusionArrayFromDelegate(IntPtr properties, IntPtr occlusionProbes, int sourceStart, int destStart, int count);

		// Token: 0x02000545 RID: 1349
		// (Invoke) Token: 0x060028C0 RID: 10432
		private delegate bool get_isEmptyDelegate(IntPtr @this);

		// Token: 0x02000546 RID: 1350
		// (Invoke) Token: 0x060028C2 RID: 10434
		private delegate void GetVectorImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);

		// Token: 0x02000547 RID: 1351
		// (Invoke) Token: 0x060028C4 RID: 10436
		private delegate void GetColorImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);

		// Token: 0x02000548 RID: 1352
		// (Invoke) Token: 0x060028C6 RID: 10438
		private delegate void GetMatrixImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);
	}
}
