using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000059 RID: 89
	public class GroupEnumerator : Object
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x00026430 File Offset: 0x00024630
		// Note: this type is marked as 'beforefieldinit'.
		static GroupEnumerator()
		{
			Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "GroupEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr);
			GroupEnumerator.NativeFieldInfoPtr__rgc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr, "_rgc");
			GroupEnumerator.NativeFieldInfoPtr__curindex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr, "_curindex");
			GroupEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_GroupCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr, 100664167);
			GroupEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr, 100664168);
			GroupEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr, 100664169);
			GroupEnumerator.NativeMethodInfoPtr_get_Capture_Public_get_Capture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr, 100664170);
			GroupEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr, 100664171);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000264EC File Offset: 0x000246EC
		[CallerCount(0)]
		public unsafe GroupEnumerator(GroupCollection rgc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_GroupCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00026538 File Offset: 0x00024738
		[CallerCount(0)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00026574 File Offset: 0x00024774
		public unsafe virtual Object Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370640, XrefRangeEnd = 370649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x000265B4 File Offset: 0x000247B4
		public unsafe Capture Capture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupEnumerator.NativeMethodInfoPtr_get_Capture_Public_get_Capture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Capture>(intPtr3) : null;
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000265F4 File Offset: 0x000247F4
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000041E4 File Offset: 0x000023E4
		public GroupEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00026628 File Offset: 0x00024828
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x000041ED File Offset: 0x000023ED
		public unsafe GroupCollection _rgc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupEnumerator.NativeFieldInfoPtr__rgc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GroupCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupEnumerator.NativeFieldInfoPtr__rgc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00026658 File Offset: 0x00024858
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x0000420C File Offset: 0x0000240C
		public unsafe int _curindex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupEnumerator.NativeFieldInfoPtr__curindex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupEnumerator.NativeFieldInfoPtr__curindex)) = value;
			}
		}

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeFieldInfoPtr__rgc;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr__curindex;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GroupCollection_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_get_Capture_Public_get_Capture_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
