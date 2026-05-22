using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001CA RID: 458
	public class StoppedEventArgs : EventArgs
	{
		// Token: 0x06001634 RID: 5684 RVA: 0x00064E58 File Offset: 0x00063058
		// Note: this type is marked as 'beforefieldinit'.
		static StoppedEventArgs()
		{
			Il2CppClassPointerStore<StoppedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "StoppedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoppedEventArgs>.NativeClassPtr);
			StoppedEventArgs.NativeFieldInfoPtr_messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoppedEventArgs>.NativeClassPtr, "messages");
			StoppedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoppedEventArgs>.NativeClassPtr, 100666437);
			StoppedEventArgs.NativeMethodInfoPtr_get_Messages_Public_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoppedEventArgs>.NativeClassPtr, 100666438);
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00064EC4 File Offset: 0x000630C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17080, XrefRangeEnd = 17083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoppedEventArgs(ICollection messages)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoppedEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(messages);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoppedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x00064F10 File Offset: 0x00063110
		public unsafe ICollection Messages
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoppedEventArgs.NativeMethodInfoPtr_get_Messages_Public_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00008EBF File Offset: 0x000070BF
		public StoppedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x00064F50 File Offset: 0x00063150
		// (set) Token: 0x06001639 RID: 5689 RVA: 0x00008EC8 File Offset: 0x000070C8
		public unsafe ICollection messages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoppedEventArgs.NativeFieldInfoPtr_messages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoppedEventArgs.NativeFieldInfoPtr_messages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeFieldInfoPtr_messages;

		// Token: 0x040017EA RID: 6122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ICollection_0;

		// Token: 0x040017EB RID: 6123
		private static readonly IntPtr NativeMethodInfoPtr_get_Messages_Public_get_ICollection_0;
	}
}
