using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003F3 RID: 1011
	[Serializable]
	public class Header : Object
	{
		// Token: 0x060040FA RID: 16634 RVA: 0x0012F8C0 File Offset: 0x0012DAC0
		// Note: this type is marked as 'beforefieldinit'.
		static Header()
		{
			Il2CppClassPointerStore<Header>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "Header");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Header>.NativeClassPtr);
			Header.NativeFieldInfoPtr_HeaderNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Header>.NativeClassPtr, "HeaderNamespace");
			Header.NativeFieldInfoPtr_MustUnderstand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Header>.NativeClassPtr, "MustUnderstand");
			Header.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Header>.NativeClassPtr, "Name");
			Header.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Header>.NativeClassPtr, "Value");
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x000186BE File Offset: 0x000168BE
		public Header(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x060040FC RID: 16636 RVA: 0x0012F940 File Offset: 0x0012DB40
		// (set) Token: 0x060040FD RID: 16637 RVA: 0x000186C7 File Offset: 0x000168C7
		public unsafe string HeaderNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_HeaderNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_HeaderNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x060040FE RID: 16638 RVA: 0x0012F968 File Offset: 0x0012DB68
		// (set) Token: 0x060040FF RID: 16639 RVA: 0x000186E6 File Offset: 0x000168E6
		public unsafe bool MustUnderstand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_MustUnderstand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_MustUnderstand)) = value;
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06004100 RID: 16640 RVA: 0x0012F990 File Offset: 0x0012DB90
		// (set) Token: 0x06004101 RID: 16641 RVA: 0x00018701 File Offset: 0x00016901
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06004102 RID: 16642 RVA: 0x0012F9B8 File Offset: 0x0012DBB8
		// (set) Token: 0x06004103 RID: 16643 RVA: 0x00018720 File Offset: 0x00016920
		public unsafe Object Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_Value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003535 RID: 13621
		private static readonly IntPtr NativeFieldInfoPtr_HeaderNamespace;

		// Token: 0x04003536 RID: 13622
		private static readonly IntPtr NativeFieldInfoPtr_MustUnderstand;

		// Token: 0x04003537 RID: 13623
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04003538 RID: 13624
		private static readonly IntPtr NativeFieldInfoPtr_Value;
	}
}
