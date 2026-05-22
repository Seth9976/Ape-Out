using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000400 RID: 1024
	public class MethodReturnDictionary : MessageDictionary
	{
		// Token: 0x060041C0 RID: 16832 RVA: 0x00132768 File Offset: 0x00130968
		// Note: this type is marked as 'beforefieldinit'.
		static MethodReturnDictionary()
		{
			Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MethodReturnDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr);
			MethodReturnDictionary.NativeFieldInfoPtr_InternalReturnKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr, "InternalReturnKeys");
			MethodReturnDictionary.NativeFieldInfoPtr_InternalExceptionKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr, "InternalExceptionKeys");
			MethodReturnDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodReturnMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr, 100672947);
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x001327D4 File Offset: 0x001309D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 225432, RefRangeEnd = 225435, XrefRangeStart = 225425, XrefRangeEnd = 225432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodReturnDictionary(IMethodReturnMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodReturnDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodReturnMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x00018BE7 File Offset: 0x00016DE7
		public MethodReturnDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x060041C3 RID: 16835 RVA: 0x00132820 File Offset: 0x00130A20
		// (set) Token: 0x060041C4 RID: 16836 RVA: 0x00018BF0 File Offset: 0x00016DF0
		public unsafe static Il2CppStringArray InternalReturnKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MethodReturnDictionary.NativeFieldInfoPtr_InternalReturnKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MethodReturnDictionary.NativeFieldInfoPtr_InternalReturnKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x060041C5 RID: 16837 RVA: 0x00132848 File Offset: 0x00130A48
		// (set) Token: 0x060041C6 RID: 16838 RVA: 0x00018C02 File Offset: 0x00016E02
		public unsafe static Il2CppStringArray InternalExceptionKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MethodReturnDictionary.NativeFieldInfoPtr_InternalExceptionKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MethodReturnDictionary.NativeFieldInfoPtr_InternalExceptionKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040035BB RID: 13755
		private static readonly IntPtr NativeFieldInfoPtr_InternalReturnKeys;

		// Token: 0x040035BC RID: 13756
		private static readonly IntPtr NativeFieldInfoPtr_InternalExceptionKeys;

		// Token: 0x040035BD RID: 13757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodReturnMessage_0;
	}
}
