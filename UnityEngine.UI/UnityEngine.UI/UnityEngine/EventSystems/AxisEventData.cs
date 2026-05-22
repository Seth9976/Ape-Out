using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200004C RID: 76
	public class AxisEventData : BaseEventData
	{
		// Token: 0x060008BB RID: 2235 RVA: 0x00028F84 File Offset: 0x00027184
		// Note: this type is marked as 'beforefieldinit'.
		static AxisEventData()
		{
			Il2CppClassPointerStore<AxisEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "AxisEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr);
			AxisEventData.NativeFieldInfoPtr__moveVector_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, "<moveVector>k__BackingField");
			AxisEventData.NativeFieldInfoPtr__moveDir_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, "<moveDir>k__BackingField");
			AxisEventData.NativeMethodInfoPtr_get_moveVector_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664710);
			AxisEventData.NativeMethodInfoPtr_set_moveVector_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664711);
			AxisEventData.NativeMethodInfoPtr_get_moveDir_Public_get_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664712);
			AxisEventData.NativeMethodInfoPtr_set_moveDir_Public_set_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664713);
			AxisEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664714);
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x00029040 File Offset: 0x00027240
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x0002907C File Offset: 0x0002727C
		public unsafe Vector2 moveVector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisEventData.NativeMethodInfoPtr_get_moveVector_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisEventData.NativeMethodInfoPtr_set_moveVector_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x000290BC File Offset: 0x000272BC
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x000290F8 File Offset: 0x000272F8
		public unsafe MoveDirection moveDir
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisEventData.NativeMethodInfoPtr_get_moveDir_Public_get_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisEventData.NativeMethodInfoPtr_set_moveDir_Public_set_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00029138 File Offset: 0x00027338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530343, XrefRangeEnd = 530345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisEventData(EventSystem eventSystem)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00005047 File Offset: 0x00003247
		public AxisEventData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00029184 File Offset: 0x00027384
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00005050 File Offset: 0x00003250
		public unsafe Vector2 _moveVector_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisEventData.NativeFieldInfoPtr__moveVector_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisEventData.NativeFieldInfoPtr__moveVector_k__BackingField)) = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x000291AC File Offset: 0x000273AC
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x0000506B File Offset: 0x0000326B
		public unsafe MoveDirection _moveDir_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisEventData.NativeFieldInfoPtr__moveDir_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisEventData.NativeFieldInfoPtr__moveDir_k__BackingField)) = value;
			}
		}

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr__moveVector_k__BackingField;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeFieldInfoPtr__moveDir_k__BackingField;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr_get_moveVector_Public_get_Vector2_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_set_moveVector_Public_set_Void_Vector2_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_get_moveDir_Public_get_MoveDirection_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_set_moveDir_Public_set_Void_MoveDirection_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;
	}
}
