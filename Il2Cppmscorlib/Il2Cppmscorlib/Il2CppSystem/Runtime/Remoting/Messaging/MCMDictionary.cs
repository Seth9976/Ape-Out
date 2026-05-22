using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003FD RID: 1021
	public class MCMDictionary : MessageDictionary
	{
		// Token: 0x06004161 RID: 16737 RVA: 0x00131000 File Offset: 0x0012F200
		// Note: this type is marked as 'beforefieldinit'.
		static MCMDictionary()
		{
			Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MCMDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr);
			MCMDictionary.NativeFieldInfoPtr_InternalKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr, "InternalKeys");
			MCMDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr, 100672890);
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x00131058 File Offset: 0x0012F258
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224952, RefRangeEnd = 224954, XrefRangeStart = 224948, XrefRangeEnd = 224952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MCMDictionary(IMethodMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MCMDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x00018971 File Offset: 0x00016B71
		public MCMDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06004164 RID: 16740 RVA: 0x001310A4 File Offset: 0x0012F2A4
		// (set) Token: 0x06004165 RID: 16741 RVA: 0x0001897A File Offset: 0x00016B7A
		public unsafe static Il2CppStringArray InternalKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MCMDictionary.NativeFieldInfoPtr_InternalKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MCMDictionary.NativeFieldInfoPtr_InternalKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003576 RID: 13686
		private static readonly IntPtr NativeFieldInfoPtr_InternalKeys;

		// Token: 0x04003577 RID: 13687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0;
	}
}
