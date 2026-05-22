using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001C9 RID: 457
	public class ChasedEventArgs : EventArgs
	{
		// Token: 0x0600162E RID: 5678 RVA: 0x00064D30 File Offset: 0x00062F30
		// Note: this type is marked as 'beforefieldinit'.
		static ChasedEventArgs()
		{
			Il2CppClassPointerStore<ChasedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "ChasedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChasedEventArgs>.NativeClassPtr);
			ChasedEventArgs.NativeFieldInfoPtr_messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChasedEventArgs>.NativeClassPtr, "messages");
			ChasedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChasedEventArgs>.NativeClassPtr, 100666435);
			ChasedEventArgs.NativeMethodInfoPtr_get_Messages_Public_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChasedEventArgs>.NativeClassPtr, 100666436);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00064D9C File Offset: 0x00062F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17077, XrefRangeEnd = 17080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChasedEventArgs(ICollection messages)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChasedEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(messages);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChasedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x00064DE8 File Offset: 0x00062FE8
		public unsafe ICollection Messages
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChasedEventArgs.NativeMethodInfoPtr_get_Messages_Public_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00008E97 File Offset: 0x00007097
		public ChasedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x00064E28 File Offset: 0x00063028
		// (set) Token: 0x06001633 RID: 5683 RVA: 0x00008EA0 File Offset: 0x000070A0
		public unsafe ICollection messages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChasedEventArgs.NativeFieldInfoPtr_messages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChasedEventArgs.NativeFieldInfoPtr_messages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017E6 RID: 6118
		private static readonly IntPtr NativeFieldInfoPtr_messages;

		// Token: 0x040017E7 RID: 6119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ICollection_0;

		// Token: 0x040017E8 RID: 6120
		private static readonly IntPtr NativeMethodInfoPtr_get_Messages_Public_get_ICollection_0;
	}
}
