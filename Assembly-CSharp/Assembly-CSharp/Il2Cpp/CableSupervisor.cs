using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200009C RID: 156
	public class CableSupervisor : MonoBehaviour
	{
		// Token: 0x0600127A RID: 4730 RVA: 0x00069280 File Offset: 0x00067480
		// Note: this type is marked as 'beforefieldinit'.
		static CableSupervisor()
		{
			Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CableSupervisor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr);
			CableSupervisor.NativeFieldInfoPtr_socket1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr, "socket1");
			CableSupervisor.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr, "scale");
			CableSupervisor.NativeFieldInfoPtr_cable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr, "cable");
			CableSupervisor.NativeFieldInfoPtr_cableEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr, "cableEnd");
			CableSupervisor.NativeFieldInfoPtr_ends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr, "ends");
			CableSupervisor.NativeFieldInfoPtr_cables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr, "cables");
			CableSupervisor.NativeFieldInfoPtr_cableIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr, "cableIndex");
			CableSupervisor.NativeFieldInfoPtr_linkNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr, "linkNum");
			CableSupervisor.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr, 100664872);
			CableSupervisor.NativeMethodInfoPtr_MakeCable_Public_Void_Transform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr, 100664873);
			CableSupervisor.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr, 100664874);
			CableSupervisor.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr, 100664875);
			CableSupervisor.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr, 100664876);
			CableSupervisor.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr, 100664877);
			CableSupervisor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr, 100664878);
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x000693DC File Offset: 0x000675DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50053, XrefRangeEnd = 50075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CableSupervisor.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00069410 File Offset: 0x00067610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50110, RefRangeEnd = 50111, XrefRangeStart = 50075, XrefRangeEnd = 50110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeCable(Transform socket, Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CableSupervisor.NativeMethodInfoPtr_MakeCable_Public_Void_Transform_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00069460 File Offset: 0x00067660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50111, XrefRangeEnd = 50134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CableSupervisor.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00069494 File Offset: 0x00067694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50134, XrefRangeEnd = 50152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CableSupervisor.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x000694C8 File Offset: 0x000676C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50152, XrefRangeEnd = 50170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CableSupervisor.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x000694FC File Offset: 0x000676FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50170, XrefRangeEnd = 50190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CableSupervisor.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00069530 File Offset: 0x00067730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50190, XrefRangeEnd = 50193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CableSupervisor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CableSupervisor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CableSupervisor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0000D85B File Offset: 0x0000BA5B
		public CableSupervisor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x0006956C File Offset: 0x0006776C
		// (set) Token: 0x06001284 RID: 4740 RVA: 0x0000D864 File Offset: 0x0000BA64
		public unsafe Transform socket1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_socket1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_socket1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x0006959C File Offset: 0x0006779C
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x0000D883 File Offset: 0x0000BA83
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x000695C4 File Offset: 0x000677C4
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x0000D89E File Offset: 0x0000BA9E
		public unsafe GameObject cable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_cable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_cable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x000695F4 File Offset: 0x000677F4
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x0000D8BD File Offset: 0x0000BABD
		public unsafe GameObject cableEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_cableEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_cableEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x00069624 File Offset: 0x00067824
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x0000D8DC File Offset: 0x0000BADC
		public unsafe Il2CppReferenceArray<CableCap> ends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_ends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CableCap>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_ends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x00069654 File Offset: 0x00067854
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x0000D8FB File Offset: 0x0000BAFB
		public unsafe Il2CppReferenceArray<Cable> cables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_cables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Cable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_cables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x00069684 File Offset: 0x00067884
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x0000D91A File Offset: 0x0000BB1A
		public unsafe int cableIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_cableIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_cableIndex)) = value;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x000696AC File Offset: 0x000678AC
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x0000D935 File Offset: 0x0000BB35
		public unsafe int linkNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_linkNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CableSupervisor.NativeFieldInfoPtr_linkNum)) = value;
			}
		}

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeFieldInfoPtr_socket1;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeFieldInfoPtr_cable;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeFieldInfoPtr_cableEnd;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeFieldInfoPtr_ends;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeFieldInfoPtr_cables;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeFieldInfoPtr_cableIndex;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeFieldInfoPtr_linkNum;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_MakeCable_Public_Void_Transform_Vector2_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
