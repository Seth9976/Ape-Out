using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Net
{
	// Token: 0x02000013 RID: 19
	public class CFUrl : CFObject
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x00013610 File Offset: 0x00011810
		// Note: this type is marked as 'beforefieldinit'.
		static CFUrl()
		{
			Il2CppClassPointerStore<CFUrl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net", "CFUrl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFUrl>.NativeClassPtr);
			CFUrl.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFUrl>.NativeClassPtr, 100663537);
			CFUrl.NativeMethodInfoPtr_CFURLCreateWithString_Private_Static_IntPtr_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFUrl>.NativeClassPtr, 100663538);
			CFUrl.NativeMethodInfoPtr_Create_Public_Static_CFUrl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFUrl>.NativeClassPtr, 100663539);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0001367C File Offset: 0x0001187C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CFUrl(IntPtr handle, bool own)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFUrl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref own;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFUrl.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000136D4 File Offset: 0x000118D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365023, XrefRangeEnd = 365025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFURLCreateWithString(IntPtr allocator, IntPtr str, IntPtr baseURL)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allocator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref str;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseURL;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFUrl.NativeMethodInfoPtr_CFURLCreateWithString_Private_Static_IntPtr_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00013730 File Offset: 0x00011930
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 365038, RefRangeEnd = 365043, XrefRangeStart = 365025, XrefRangeEnd = 365038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CFUrl Create(string absolute)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(absolute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFUrl.NativeMethodInfoPtr_Create_Public_Static_CFUrl_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CFUrl>(intPtr3) : null;
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002432 File Offset: 0x00000632
		public CFUrl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_CFURLCreateWithString_Private_Static_IntPtr_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_CFUrl_String_0;
	}
}
