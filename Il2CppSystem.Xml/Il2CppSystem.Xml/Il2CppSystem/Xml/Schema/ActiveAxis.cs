using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000F6 RID: 246
	public class ActiveAxis : Object
	{
		// Token: 0x06001490 RID: 5264 RVA: 0x0006B51C File Offset: 0x0006971C
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveAxis()
		{
			Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ActiveAxis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr);
			ActiveAxis.NativeFieldInfoPtr_currentDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, "currentDepth");
			ActiveAxis.NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, "isActive");
			ActiveAxis.NativeFieldInfoPtr_axisTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, "axisTree");
			ActiveAxis.NativeFieldInfoPtr_axisStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, "axisStack");
			ActiveAxis.NativeMethodInfoPtr_get_CurrentDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, 100666449);
			ActiveAxis.NativeMethodInfoPtr_Reactivate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, 100666450);
			ActiveAxis.NativeMethodInfoPtr__ctor_Internal_Void_Asttree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, 100666451);
			ActiveAxis.NativeMethodInfoPtr_MoveToStartElement_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, 100666452);
			ActiveAxis.NativeMethodInfoPtr_EndElement_Public_Virtual_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, 100666453);
			ActiveAxis.NativeMethodInfoPtr_MoveToAttribute_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, 100666454);
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x0006B614 File Offset: 0x00069814
		public unsafe int CurrentDepth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAxis.NativeMethodInfoPtr_get_CurrentDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0006B650 File Offset: 0x00069850
		[CallerCount(0)]
		public unsafe void Reactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAxis.NativeMethodInfoPtr_Reactivate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0006B684 File Offset: 0x00069884
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 407939, RefRangeEnd = 407943, XrefRangeStart = 407923, XrefRangeEnd = 407939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveAxis(Asttree axisTree)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axisTree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAxis.NativeMethodInfoPtr__ctor_Internal_Void_Asttree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0006B6D0 File Offset: 0x000698D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 407948, RefRangeEnd = 407952, XrefRangeStart = 407943, XrefRangeEnd = 407948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToStartElement(string localname, string URN)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAxis.NativeMethodInfoPtr_MoveToStartElement_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0006B730 File Offset: 0x00069930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407952, XrefRangeEnd = 407953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EndElement(string localname, string URN)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAxis.NativeMethodInfoPtr_EndElement_Public_Virtual_New_Boolean_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0006B79C File Offset: 0x0006999C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407957, RefRangeEnd = 407959, XrefRangeStart = 407953, XrefRangeEnd = 407957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToAttribute(string localname, string URN)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAxis.NativeMethodInfoPtr_MoveToAttribute_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x000092FA File Offset: 0x000074FA
		public ActiveAxis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x0006B7FC File Offset: 0x000699FC
		// (set) Token: 0x06001499 RID: 5273 RVA: 0x00009303 File Offset: 0x00007503
		public unsafe int currentDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr_currentDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr_currentDepth)) = value;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x0006B824 File Offset: 0x00069A24
		// (set) Token: 0x0600149B RID: 5275 RVA: 0x0000931E File Offset: 0x0000751E
		public unsafe bool isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr_isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr_isActive)) = value;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x0006B84C File Offset: 0x00069A4C
		// (set) Token: 0x0600149D RID: 5277 RVA: 0x00009339 File Offset: 0x00007539
		public unsafe Asttree axisTree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr_axisTree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Asttree>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr_axisTree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x0006B87C File Offset: 0x00069A7C
		// (set) Token: 0x0600149F RID: 5279 RVA: 0x00009358 File Offset: 0x00007558
		public unsafe ArrayList axisStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr_axisStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr_axisStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeFieldInfoPtr_currentDepth;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeFieldInfoPtr_isActive;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeFieldInfoPtr_axisTree;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeFieldInfoPtr_axisStack;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDepth_Public_get_Int32_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr_Reactivate_Internal_Void_0;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Asttree_0;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr_MoveToStartElement_Public_Boolean_String_String_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr_EndElement_Public_Virtual_New_Boolean_String_String_0;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Boolean_String_String_0;
	}
}
