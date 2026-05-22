using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x02000056 RID: 86
	[Serializable]
	public class TMP_TextInfo : global::Il2CppSystem.Object
	{
		// Token: 0x06000B1F RID: 2847 RVA: 0x0002FAEC File Offset: 0x0002DCEC
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextInfo()
		{
			Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_TextInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr);
			TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorPositive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "k_InfinityVectorPositive");
			TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorNegative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "k_InfinityVectorNegative");
			TMP_TextInfo.NativeFieldInfoPtr_textComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "textComponent");
			TMP_TextInfo.NativeFieldInfoPtr_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "characterCount");
			TMP_TextInfo.NativeFieldInfoPtr_spriteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "spriteCount");
			TMP_TextInfo.NativeFieldInfoPtr_spaceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "spaceCount");
			TMP_TextInfo.NativeFieldInfoPtr_wordCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "wordCount");
			TMP_TextInfo.NativeFieldInfoPtr_linkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "linkCount");
			TMP_TextInfo.NativeFieldInfoPtr_lineCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "lineCount");
			TMP_TextInfo.NativeFieldInfoPtr_pageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "pageCount");
			TMP_TextInfo.NativeFieldInfoPtr_materialCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "materialCount");
			TMP_TextInfo.NativeFieldInfoPtr_characterInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "characterInfo");
			TMP_TextInfo.NativeFieldInfoPtr_wordInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "wordInfo");
			TMP_TextInfo.NativeFieldInfoPtr_linkInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "linkInfo");
			TMP_TextInfo.NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "lineInfo");
			TMP_TextInfo.NativeFieldInfoPtr_pageInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "pageInfo");
			TMP_TextInfo.NativeFieldInfoPtr_meshInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "meshInfo");
			TMP_TextInfo.NativeFieldInfoPtr_m_CachedMeshInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "m_CachedMeshInfo");
			TMP_TextInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664567);
			TMP_TextInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664568);
			TMP_TextInfo.NativeMethodInfoPtr__ctor_Public_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664569);
			TMP_TextInfo.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664570);
			TMP_TextInfo.NativeMethodInfoPtr_ClearAllData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664571);
			TMP_TextInfo.NativeMethodInfoPtr_ClearMeshInfo_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664572);
			TMP_TextInfo.NativeMethodInfoPtr_ClearAllMeshInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664573);
			TMP_TextInfo.NativeMethodInfoPtr_ResetVertexLayout_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664574);
			TMP_TextInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Il2CppReferenceArray_1_MaterialReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664575);
			TMP_TextInfo.NativeMethodInfoPtr_ClearLineInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664576);
			TMP_TextInfo.NativeMethodInfoPtr_ClearPageInfo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664577);
			TMP_TextInfo.NativeMethodInfoPtr_CopyMeshInfoVertexData_Public_Il2CppReferenceArray_1_TMP_MeshInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664578);
			TMP_TextInfo.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664579);
			TMP_TextInfo.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664580);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0002FD9C File Offset: 0x0002DF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463303, XrefRangeEnd = 463321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0002FDD8 File Offset: 0x0002DFD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463339, RefRangeEnd = 463341, XrefRangeStart = 463321, XrefRangeEnd = 463339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextInfo(int characterCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref characterCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0002FE20 File Offset: 0x0002E020
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463359, RefRangeEnd = 463361, XrefRangeStart = 463341, XrefRangeEnd = 463359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextInfo(TMP_Text textComponent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr__ctor_Public_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0002FE6C File Offset: 0x0002E06C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463362, RefRangeEnd = 463364, XrefRangeStart = 463361, XrefRangeEnd = 463362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0002FEA0 File Offset: 0x0002E0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463364, XrefRangeEnd = 463382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAllData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearAllData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0002FED4 File Offset: 0x0002E0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463382, XrefRangeEnd = 463384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearMeshInfo(bool updateMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateMesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearMeshInfo_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0002FF14 File Offset: 0x0002E114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463384, XrefRangeEnd = 463386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAllMeshInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearAllMeshInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0002FF48 File Offset: 0x0002E148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463386, XrefRangeEnd = 463388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetVertexLayout(bool isVolumetric)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVolumetric;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ResetVertexLayout_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0002FF88 File Offset: 0x0002E188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463388, XrefRangeEnd = 463390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUnusedVertices(Il2CppReferenceArray<MaterialReference> materials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(materials);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Il2CppReferenceArray_1_MaterialReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0002FFCC File Offset: 0x0002E1CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463400, RefRangeEnd = 463402, XrefRangeStart = 463390, XrefRangeEnd = 463400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearLineInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00030000 File Offset: 0x0002E200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463405, RefRangeEnd = 463407, XrefRangeStart = 463402, XrefRangeEnd = 463405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPageInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearPageInfo_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00030034 File Offset: 0x0002E234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463407, XrefRangeEnd = 463439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TMP_MeshInfo> CopyMeshInfoVertexData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_CopyMeshInfoVertexData_Public_Il2CppReferenceArray_1_TMP_MeshInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_MeshInfo>>(intPtr3) : null;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00030074 File Offset: 0x0002E274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463444, RefRangeEnd = 463446, XrefRangeStart = 463439, XrefRangeEnd = 463444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resize<T>(ref Il2CppArrayBase<T> array, int size)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x000300D0 File Offset: 0x0002E2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463446, XrefRangeEnd = 463449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resize<T>(ref Il2CppArrayBase<T> array, int size, bool isBlockAllocated)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBlockAllocated;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x000073D1 File Offset: 0x000055D1
		public TMP_TextInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00030138 File Offset: 0x0002E338
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x000073DA File Offset: 0x000055DA
		public unsafe static Vector2 k_InfinityVectorPositive
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorPositive, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorPositive, (void*)(&value));
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x00030154 File Offset: 0x0002E354
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x000073E8 File Offset: 0x000055E8
		public unsafe static Vector2 k_InfinityVectorNegative
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorNegative, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorNegative, (void*)(&value));
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x00030170 File Offset: 0x0002E370
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x000073F6 File Offset: 0x000055F6
		public unsafe TMP_Text textComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_textComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_textComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x000301A0 File Offset: 0x0002E3A0
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x00007415 File Offset: 0x00005615
		public unsafe int characterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_characterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_characterCount)) = value;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x000301C8 File Offset: 0x0002E3C8
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x00007430 File Offset: 0x00005630
		public unsafe int spriteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_spriteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_spriteCount)) = value;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x000301F0 File Offset: 0x0002E3F0
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x0000744B File Offset: 0x0000564B
		public unsafe int spaceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_spaceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_spaceCount)) = value;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00030218 File Offset: 0x0002E418
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x00007466 File Offset: 0x00005666
		public unsafe int wordCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_wordCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_wordCount)) = value;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00030240 File Offset: 0x0002E440
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00007481 File Offset: 0x00005681
		public unsafe int linkCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_linkCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_linkCount)) = value;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00030268 File Offset: 0x0002E468
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x0000749C File Offset: 0x0000569C
		public unsafe int lineCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_lineCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_lineCount)) = value;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00030290 File Offset: 0x0002E490
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x000074B7 File Offset: 0x000056B7
		public unsafe int pageCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_pageCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_pageCount)) = value;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x000302B8 File Offset: 0x0002E4B8
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x000074D2 File Offset: 0x000056D2
		public unsafe int materialCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_materialCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_materialCount)) = value;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x000302E0 File Offset: 0x0002E4E0
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x000074ED File Offset: 0x000056ED
		public unsafe Il2CppReferenceArray<TMP_CharacterInfo> characterInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_characterInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_CharacterInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_characterInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x00030310 File Offset: 0x0002E510
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x0000750C File Offset: 0x0000570C
		public unsafe Il2CppReferenceArray<TMP_WordInfo> wordInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_wordInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_WordInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_wordInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x00030340 File Offset: 0x0002E540
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x0000752B File Offset: 0x0000572B
		public unsafe Il2CppReferenceArray<TMP_LinkInfo> linkInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_linkInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_LinkInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_linkInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00030370 File Offset: 0x0002E570
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x0000754A File Offset: 0x0000574A
		public unsafe Il2CppStructArray<TMP_LineInfo> lineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_lineInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TMP_LineInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_lineInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x000303A0 File Offset: 0x0002E5A0
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x00007569 File Offset: 0x00005769
		public unsafe Il2CppStructArray<TMP_PageInfo> pageInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_pageInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TMP_PageInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_pageInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x000303D0 File Offset: 0x0002E5D0
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x00007588 File Offset: 0x00005788
		public unsafe Il2CppReferenceArray<TMP_MeshInfo> meshInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_meshInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_MeshInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_meshInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00030400 File Offset: 0x0002E600
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x000075A7 File Offset: 0x000057A7
		public unsafe Il2CppReferenceArray<TMP_MeshInfo> m_CachedMeshInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_m_CachedMeshInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_MeshInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_m_CachedMeshInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeFieldInfoPtr_k_InfinityVectorPositive;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeFieldInfoPtr_k_InfinityVectorNegative;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeFieldInfoPtr_textComponent;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeFieldInfoPtr_characterCount;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeFieldInfoPtr_spriteCount;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_spaceCount;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_wordCount;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_linkCount;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_lineCount;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeFieldInfoPtr_pageCount;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeFieldInfoPtr_materialCount;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeFieldInfoPtr_characterInfo;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeFieldInfoPtr_wordInfo;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeFieldInfoPtr_linkInfo;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeFieldInfoPtr_lineInfo;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeFieldInfoPtr_pageInfo;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeFieldInfoPtr_meshInfo;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedMeshInfo;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TMP_Text_0;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllData_Internal_Void_0;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeMethodInfoPtr_ClearMeshInfo_Public_Void_Boolean_0;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllMeshInfo_Public_Void_0;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeMethodInfoPtr_ResetVertexLayout_Public_Void_Boolean_0;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Il2CppReferenceArray_1_MaterialReference_0;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeMethodInfoPtr_ClearLineInfo_Public_Void_0;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr_ClearPageInfo_Internal_Void_0;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeMethodInfoPtr_CopyMeshInfoVertexData_Public_Il2CppReferenceArray_1_TMP_MeshInfo_0;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0;

		// Token: 0x020000AC RID: 172
		private sealed class MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04000C87 RID: 3207
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_TextInfo.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000AD RID: 173
		private sealed class MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0<T>
		{
			// Token: 0x04000C88 RID: 3208
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_TextInfo.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0, Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
