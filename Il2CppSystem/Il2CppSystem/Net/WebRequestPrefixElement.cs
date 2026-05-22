using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000F3 RID: 243
	public class WebRequestPrefixElement : Object
	{
		// Token: 0x06000D46 RID: 3398 RVA: 0x000425BC File Offset: 0x000407BC
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestPrefixElement()
		{
			Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebRequestPrefixElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr);
			WebRequestPrefixElement.NativeFieldInfoPtr_Prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, "Prefix");
			WebRequestPrefixElement.NativeFieldInfoPtr_creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, "creator");
			WebRequestPrefixElement.NativeFieldInfoPtr_creatorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, "creatorType");
			WebRequestPrefixElement.NativeMethodInfoPtr_get_Creator_Public_get_IWebRequestCreate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, 100665210);
			WebRequestPrefixElement.NativeMethodInfoPtr_set_Creator_Public_set_Void_IWebRequestCreate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, 100665211);
			WebRequestPrefixElement.NativeMethodInfoPtr__ctor_Public_Void_String_IWebRequestCreate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, 100665212);
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x00042664 File Offset: 0x00040864
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x000426A4 File Offset: 0x000408A4
		public unsafe IWebRequestCreate Creator
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 376853, RefRangeEnd = 376854, XrefRangeStart = 376832, XrefRangeEnd = 376853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestPrefixElement.NativeMethodInfoPtr_get_Creator_Public_get_IWebRequestCreate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebRequestCreate>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestPrefixElement.NativeMethodInfoPtr_set_Creator_Public_set_Void_IWebRequestCreate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x000426E8 File Offset: 0x000408E8
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequestPrefixElement(string P, IWebRequestCreate C)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(P);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(C);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestPrefixElement.NativeMethodInfoPtr__ctor_Public_Void_String_IWebRequestCreate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x000073E9 File Offset: 0x000055E9
		public WebRequestPrefixElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00042748 File Offset: 0x00040948
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x000073F2 File Offset: 0x000055F2
		public unsafe string Prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_Prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_Prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x00042770 File Offset: 0x00040970
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x00007411 File Offset: 0x00005611
		public unsafe IWebRequestCreate creator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_creator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebRequestCreate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_creator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x000427A0 File Offset: 0x000409A0
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x00007430 File Offset: 0x00005630
		public unsafe Type creatorType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_creatorType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_creatorType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeFieldInfoPtr_Prefix;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeFieldInfoPtr_creator;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeFieldInfoPtr_creatorType;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_get_Creator_Public_get_IWebRequestCreate_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_set_Creator_Public_set_Void_IWebRequestCreate_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IWebRequestCreate_0;
	}
}
