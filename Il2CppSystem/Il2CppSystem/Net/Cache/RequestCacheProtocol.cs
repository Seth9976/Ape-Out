using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x02000173 RID: 371
	public class RequestCacheProtocol : Object
	{
		// Token: 0x06001701 RID: 5889 RVA: 0x0000B788 File Offset: 0x00009988
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCacheProtocol()
		{
			Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCacheProtocol");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr);
			RequestCacheProtocol.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr, 100666529);
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00066C18 File Offset: 0x00064E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388670, XrefRangeEnd = 388675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestCacheProtocol(Object arg1, Object arg2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheProtocol.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x0000B7C1 File Offset: 0x000099C1
		public RequestCacheProtocol(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0;
	}
}
