using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000182 RID: 386
	public class ShadowLayerer : MonoBehaviour
	{
		// Token: 0x06002DD3 RID: 11731 RVA: 0x000B2930 File Offset: 0x000B0B30
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowLayerer()
		{
			Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ShadowLayerer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr);
			ShadowLayerer.NativeFieldInfoPtr_shadowArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "shadowArr");
			ShadowLayerer.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "player");
			ShadowLayerer.NativeFieldInfoPtr_angNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "angNum");
			ShadowLayerer.NativeFieldInfoPtr_constraintArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "constraintArr");
			ShadowLayerer.NativeFieldInfoPtr_lay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "lay");
			ShadowLayerer.NativeFieldInfoPtr_debugList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "debugList");
			ShadowLayerer.NativeFieldInfoPtr_debugging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "debugging");
			ShadowLayerer.NativeFieldInfoPtr_a1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "a1");
			ShadowLayerer.NativeFieldInfoPtr_a2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "a2");
			ShadowLayerer.NativeFieldInfoPtr_b1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "b1");
			ShadowLayerer.NativeFieldInfoPtr_b2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "b2");
			ShadowLayerer.NativeFieldInfoPtr_blap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "blap");
			ShadowLayerer.NativeFieldInfoPtr_pPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "pPos");
			ShadowLayerer.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "me");
			ShadowLayerer.NativeFieldInfoPtr_sortList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "sortList");
			ShadowLayerer.NativeFieldInfoPtr_utilLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, "utilLayer");
			ShadowLayerer.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, 100666879);
			ShadowLayerer.NativeMethodInfoPtr_GetShadow_Public_Void_Vector2_Vector2_GameObject_Renderer_Renderer_Int32_Int32_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, 100666880);
			ShadowLayerer.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, 100666881);
			ShadowLayerer.NativeMethodInfoPtr_GetConstraints_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, 100666882);
			ShadowLayerer.NativeMethodInfoPtr_GetConstraint_Public_Void_byref_ShadowAng_byref_ShadowAng_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, 100666883);
			ShadowLayerer.NativeMethodInfoPtr_AddConstraint_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, 100666884);
			ShadowLayerer.NativeMethodInfoPtr_GetMidPoints_Public_Vector2_ShadowAng_ShadowAng_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, 100666885);
			ShadowLayerer.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, 100666886);
			ShadowLayerer.NativeMethodInfoPtr_SpecialContains_Public_Boolean_byref_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, 100666887);
			ShadowLayerer.NativeMethodInfoPtr_RayHit_Public_Boolean_Vector2_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, 100666888);
			ShadowLayerer.NativeMethodInfoPtr_SortLayers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, 100666889);
			ShadowLayerer.NativeMethodInfoPtr_ChangeLayer_Public_Void_Int32_byref_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, 100666890);
			ShadowLayerer.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, 100666891);
			ShadowLayerer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr, 100666892);
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x000B2BB8 File Offset: 0x000B0DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81406, XrefRangeEnd = 81454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLayerer.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x000B2BEC File Offset: 0x000B0DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81462, RefRangeEnd = 81463, XrefRangeStart = 81454, XrefRangeEnd = 81462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetShadow(Vector2 p1, Vector2 p2, GameObject obj, Renderer mRenderer, Renderer sRenderer, int palIndex, int matIndex, Il2CppStructArray<Vector2> pts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mRenderer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sRenderer);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref palIndex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLayerer.NativeMethodInfoPtr_GetShadow_Public_Void_Vector2_Vector2_GameObject_Renderer_Renderer_Int32_Int32_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x000B2CA0 File Offset: 0x000B0EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81463, XrefRangeEnd = 81484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLayerer.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x000B2CD4 File Offset: 0x000B0ED4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81490, RefRangeEnd = 81491, XrefRangeStart = 81484, XrefRangeEnd = 81490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLayerer.NativeMethodInfoPtr_GetConstraints_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x000B2D08 File Offset: 0x000B0F08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81505, RefRangeEnd = 81506, XrefRangeStart = 81491, XrefRangeEnd = 81505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetConstraint(ref ShadowAng a, ref ShadowAng b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ShadowLayerer.NativeMethodInfoPtr_GetConstraint_Public_Void_byref_ShadowAng_byref_ShadowAng_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			a = ((intPtr5 == 0) ? null : new ShadowAng(intPtr5));
			IntPtr intPtr6 = intPtr2;
			b = ((intPtr6 == 0) ? null : new ShadowAng(intPtr6));
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x000B2D88 File Offset: 0x000B0F88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81506, RefRangeEnd = 81507, XrefRangeStart = 81506, XrefRangeEnd = 81506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConstraint(int index, int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLayerer.NativeMethodInfoPtr_AddConstraint_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x000B2DD4 File Offset: 0x000B0FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81507, XrefRangeEnd = 81525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetMidPoints(ShadowAng a, ShadowAng b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLayerer.NativeMethodInfoPtr_GetMidPoints_Public_Vector2_ShadowAng_ShadowAng_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x000B2E34 File Offset: 0x000B1034
		[CallerCount(0)]
		public unsafe bool Contains(int index, int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLayerer.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x000B2E8C File Offset: 0x000B108C
		[CallerCount(0)]
		public unsafe bool SpecialContains(ref Il2CppStructArray<uint> arr, int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(arr);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShadowLayerer.NativeMethodInfoPtr_SpecialContains_Public_Boolean_byref_Il2CppStructArray_1_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			arr = ((intPtr4 == 0) ? null : new Il2CppStructArray<uint>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x000B2F00 File Offset: 0x000B1100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81525, XrefRangeEnd = 81553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RayHit(Vector2 pt, GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLayerer.NativeMethodInfoPtr_RayHit_Public_Boolean_Vector2_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x000B2F5C File Offset: 0x000B115C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81563, RefRangeEnd = 81564, XrefRangeStart = 81553, XrefRangeEnd = 81563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortLayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLayerer.NativeMethodInfoPtr_SortLayers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x000B2F90 File Offset: 0x000B1190
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81568, RefRangeEnd = 81570, XrefRangeStart = 81564, XrefRangeEnd = 81568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeLayer(int index, ref List<int> list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShadowLayerer.NativeMethodInfoPtr_ChangeLayer_Public_Void_Int32_byref_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			list = ((intPtr4 == 0) ? null : new List<int>(intPtr4));
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x000B2FF8 File Offset: 0x000B11F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81570, XrefRangeEnd = 81592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLayerer.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x000B302C File Offset: 0x000B122C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShadowLayerer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowLayerer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLayerer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x0001FAF1 File Offset: 0x0001DCF1
		public ShadowLayerer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06002DE3 RID: 11747 RVA: 0x000B3068 File Offset: 0x000B1268
		// (set) Token: 0x06002DE4 RID: 11748 RVA: 0x0001FAFA File Offset: 0x0001DCFA
		public unsafe Il2CppReferenceArray<ShadowAng> shadowArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_shadowArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ShadowAng>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_shadowArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x06002DE5 RID: 11749 RVA: 0x000B3098 File Offset: 0x000B1298
		// (set) Token: 0x06002DE6 RID: 11750 RVA: 0x0001FB19 File Offset: 0x0001DD19
		public unsafe GameObject player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x06002DE7 RID: 11751 RVA: 0x000B30C8 File Offset: 0x000B12C8
		// (set) Token: 0x06002DE8 RID: 11752 RVA: 0x0001FB38 File Offset: 0x0001DD38
		public unsafe int angNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_angNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_angNum)) = value;
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06002DE9 RID: 11753 RVA: 0x000B30F0 File Offset: 0x000B12F0
		// (set) Token: 0x06002DEA RID: 11754 RVA: 0x0001FB53 File Offset: 0x0001DD53
		public unsafe Il2CppReferenceArray<Il2CppStructArray<uint>> constraintArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_constraintArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<uint>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_constraintArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06002DEB RID: 11755 RVA: 0x000B3120 File Offset: 0x000B1320
		// (set) Token: 0x06002DEC RID: 11756 RVA: 0x0001FB72 File Offset: 0x0001DD72
		public unsafe int lay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_lay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_lay)) = value;
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x000B3148 File Offset: 0x000B1348
		// (set) Token: 0x06002DEE RID: 11758 RVA: 0x0001FB8D File Offset: 0x0001DD8D
		public unsafe List<DebugPt> debugList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_debugList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DebugPt>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_debugList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06002DEF RID: 11759 RVA: 0x000B3178 File Offset: 0x000B1378
		// (set) Token: 0x06002DF0 RID: 11760 RVA: 0x0001FBAC File Offset: 0x0001DDAC
		public unsafe bool debugging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_debugging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_debugging)) = value;
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06002DF1 RID: 11761 RVA: 0x000B31A0 File Offset: 0x000B13A0
		// (set) Token: 0x06002DF2 RID: 11762 RVA: 0x0001FBC7 File Offset: 0x0001DDC7
		public unsafe float a1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_a1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_a1)) = value;
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x000B31C8 File Offset: 0x000B13C8
		// (set) Token: 0x06002DF4 RID: 11764 RVA: 0x0001FBE2 File Offset: 0x0001DDE2
		public unsafe float a2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_a2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_a2)) = value;
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x000B31F0 File Offset: 0x000B13F0
		// (set) Token: 0x06002DF6 RID: 11766 RVA: 0x0001FBFD File Offset: 0x0001DDFD
		public unsafe float b1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_b1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_b1)) = value;
			}
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06002DF7 RID: 11767 RVA: 0x000B3218 File Offset: 0x000B1418
		// (set) Token: 0x06002DF8 RID: 11768 RVA: 0x0001FC18 File Offset: 0x0001DE18
		public unsafe float b2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_b2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_b2)) = value;
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06002DF9 RID: 11769 RVA: 0x000B3240 File Offset: 0x000B1440
		// (set) Token: 0x06002DFA RID: 11770 RVA: 0x0001FC33 File Offset: 0x0001DE33
		public unsafe Vector2 blap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_blap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_blap)) = value;
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06002DFB RID: 11771 RVA: 0x000B3268 File Offset: 0x000B1468
		// (set) Token: 0x06002DFC RID: 11772 RVA: 0x0001FC4E File Offset: 0x0001DE4E
		public unsafe Vector2 pPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_pPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_pPos)) = value;
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x000B3290 File Offset: 0x000B1490
		// (set) Token: 0x06002DFE RID: 11774 RVA: 0x0001FC69 File Offset: 0x0001DE69
		public unsafe static ShadowLayerer me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShadowLayerer.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShadowLayerer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowLayerer.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x000B32B8 File Offset: 0x000B14B8
		// (set) Token: 0x06002E00 RID: 11776 RVA: 0x0001FC7B File Offset: 0x0001DE7B
		public unsafe List<int> sortList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_sortList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_sortList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x000B32E8 File Offset: 0x000B14E8
		// (set) Token: 0x06002E02 RID: 11778 RVA: 0x0001FC9A File Offset: 0x0001DE9A
		public unsafe int utilLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_utilLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLayerer.NativeFieldInfoPtr_utilLayer)) = value;
			}
		}

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeFieldInfoPtr_shadowArr;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeFieldInfoPtr_angNum;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeFieldInfoPtr_constraintArr;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeFieldInfoPtr_lay;

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeFieldInfoPtr_debugList;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeFieldInfoPtr_debugging;

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeFieldInfoPtr_a1;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeFieldInfoPtr_a2;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeFieldInfoPtr_b1;

		// Token: 0x04001B02 RID: 6914
		private static readonly IntPtr NativeFieldInfoPtr_b2;

		// Token: 0x04001B03 RID: 6915
		private static readonly IntPtr NativeFieldInfoPtr_blap;

		// Token: 0x04001B04 RID: 6916
		private static readonly IntPtr NativeFieldInfoPtr_pPos;

		// Token: 0x04001B05 RID: 6917
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04001B06 RID: 6918
		private static readonly IntPtr NativeFieldInfoPtr_sortList;

		// Token: 0x04001B07 RID: 6919
		private static readonly IntPtr NativeFieldInfoPtr_utilLayer;

		// Token: 0x04001B08 RID: 6920
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001B09 RID: 6921
		private static readonly IntPtr NativeMethodInfoPtr_GetShadow_Public_Void_Vector2_Vector2_GameObject_Renderer_Renderer_Int32_Int32_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04001B0A RID: 6922
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04001B0B RID: 6923
		private static readonly IntPtr NativeMethodInfoPtr_GetConstraints_Public_Void_0;

		// Token: 0x04001B0C RID: 6924
		private static readonly IntPtr NativeMethodInfoPtr_GetConstraint_Public_Void_byref_ShadowAng_byref_ShadowAng_0;

		// Token: 0x04001B0D RID: 6925
		private static readonly IntPtr NativeMethodInfoPtr_AddConstraint_Public_Void_Int32_Int32_0;

		// Token: 0x04001B0E RID: 6926
		private static readonly IntPtr NativeMethodInfoPtr_GetMidPoints_Public_Vector2_ShadowAng_ShadowAng_0;

		// Token: 0x04001B0F RID: 6927
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int32_Int32_0;

		// Token: 0x04001B10 RID: 6928
		private static readonly IntPtr NativeMethodInfoPtr_SpecialContains_Public_Boolean_byref_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x04001B11 RID: 6929
		private static readonly IntPtr NativeMethodInfoPtr_RayHit_Public_Boolean_Vector2_GameObject_0;

		// Token: 0x04001B12 RID: 6930
		private static readonly IntPtr NativeMethodInfoPtr_SortLayers_Public_Void_0;

		// Token: 0x04001B13 RID: 6931
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLayer_Public_Void_Int32_byref_List_1_Int32_0;

		// Token: 0x04001B14 RID: 6932
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

		// Token: 0x04001B15 RID: 6933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
