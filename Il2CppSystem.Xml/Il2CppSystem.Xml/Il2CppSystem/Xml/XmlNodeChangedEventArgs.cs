using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200007F RID: 127
	public class XmlNodeChangedEventArgs : EventArgs
	{
		// Token: 0x06000D98 RID: 3480 RVA: 0x0004E764 File Offset: 0x0004C964
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNodeChangedEventArgs()
		{
			Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNodeChangedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr);
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "action");
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "node");
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "oldParent");
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_newParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "newParent");
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "oldValue");
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_newValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "newValue");
			XmlNodeChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, 100665458);
			XmlNodeChangedEventArgs.NativeMethodInfoPtr_get_Action_Public_get_XmlNodeChangedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, 100665459);
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0004E834 File Offset: 0x0004CA34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398970, RefRangeEnd = 398971, XrefRangeStart = 398967, XrefRangeEnd = 398970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldParent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newParent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x0004E8D8 File Offset: 0x0004CAD8
		public unsafe XmlNodeChangedAction Action
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeChangedEventArgs.NativeMethodInfoPtr_get_Action_Public_get_XmlNodeChangedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00006A9F File Offset: 0x00004C9F
		public XmlNodeChangedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x0004E914 File Offset: 0x0004CB14
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x00006AA8 File Offset: 0x00004CA8
		public unsafe XmlNodeChangedAction action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_action);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_action)) = value;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x0004E93C File Offset: 0x0004CB3C
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x00006AC3 File Offset: 0x00004CC3
		public unsafe XmlNode node
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_node);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x0004E96C File Offset: 0x0004CB6C
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x00006AE2 File Offset: 0x00004CE2
		public unsafe XmlNode oldParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x0004E99C File Offset: 0x0004CB9C
		// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x00006B01 File Offset: 0x00004D01
		public unsafe XmlNode newParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_newParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_newParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x0004E9CC File Offset: 0x0004CBCC
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x00006B20 File Offset: 0x00004D20
		public unsafe string oldValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x0004E9F4 File Offset: 0x0004CBF4
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x00006B3F File Offset: 0x00004D3F
		public unsafe string newValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_newValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_newValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeFieldInfoPtr_action;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeFieldInfoPtr_node;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeFieldInfoPtr_oldParent;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeFieldInfoPtr_newParent;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeFieldInfoPtr_oldValue;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeFieldInfoPtr_newValue;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_get_Action_Public_get_XmlNodeChangedAction_0;
	}
}
