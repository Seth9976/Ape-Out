using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000028 RID: 40
	public class HtmlTernaryTree : Object
	{
		// Token: 0x0600021B RID: 539 RVA: 0x0001B89C File Offset: 0x00019A9C
		// Note: this type is marked as 'beforefieldinit'.
		static HtmlTernaryTree()
		{
			Il2CppClassPointerStore<HtmlTernaryTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "HtmlTernaryTree");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HtmlTernaryTree>.NativeClassPtr);
			HtmlTernaryTree.NativeFieldInfoPtr_htmlElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTernaryTree>.NativeClassPtr, "htmlElements");
			HtmlTernaryTree.NativeFieldInfoPtr_htmlAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTernaryTree>.NativeClassPtr, "htmlAttributes");
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002EC1 File Offset: 0x000010C1
		public HtmlTernaryTree(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0001B8F4 File Offset: 0x00019AF4
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002ECA File Offset: 0x000010CA
		public unsafe static Il2CppStructArray<byte> htmlElements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HtmlTernaryTree.NativeFieldInfoPtr_htmlElements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HtmlTernaryTree.NativeFieldInfoPtr_htmlElements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0001B91C File Offset: 0x00019B1C
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002EDC File Offset: 0x000010DC
		public unsafe static Il2CppStructArray<byte> htmlAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HtmlTernaryTree.NativeFieldInfoPtr_htmlAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HtmlTernaryTree.NativeFieldInfoPtr_htmlAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_htmlElements;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_htmlAttributes;
	}
}
