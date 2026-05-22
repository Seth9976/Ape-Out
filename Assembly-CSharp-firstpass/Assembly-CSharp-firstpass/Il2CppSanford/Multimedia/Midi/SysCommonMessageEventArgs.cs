using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001AA RID: 426
	public class SysCommonMessageEventArgs : EventArgs
	{
		// Token: 0x0600144A RID: 5194 RVA: 0x0005DFCC File Offset: 0x0005C1CC
		// Note: this type is marked as 'beforefieldinit'.
		static SysCommonMessageEventArgs()
		{
			Il2CppClassPointerStore<SysCommonMessageEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "SysCommonMessageEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SysCommonMessageEventArgs>.NativeClassPtr);
			SysCommonMessageEventArgs.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysCommonMessageEventArgs>.NativeClassPtr, "message");
			SysCommonMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_SysCommonMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageEventArgs>.NativeClassPtr, 100666185);
			SysCommonMessageEventArgs.NativeMethodInfoPtr_get_Message_Public_get_SysCommonMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageEventArgs>.NativeClassPtr, 100666186);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0005E038 File Offset: 0x0005C238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16195, XrefRangeEnd = 16198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SysCommonMessageEventArgs(SysCommonMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SysCommonMessageEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_SysCommonMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x0005E084 File Offset: 0x0005C284
		public unsafe SysCommonMessage Message
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageEventArgs.NativeMethodInfoPtr_get_Message_Public_get_SysCommonMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SysCommonMessage>(intPtr3) : null;
			}
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x000084D1 File Offset: 0x000066D1
		public SysCommonMessageEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0005E0C4 File Offset: 0x0005C2C4
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x000084DA File Offset: 0x000066DA
		public unsafe SysCommonMessage message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SysCommonMessageEventArgs.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysCommonMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SysCommonMessageEventArgs.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400166C RID: 5740
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x0400166D RID: 5741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SysCommonMessage_0;

		// Token: 0x0400166E RID: 5742
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_SysCommonMessage_0;
	}
}
