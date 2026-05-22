using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x0200014C RID: 332
	[Serializable]
	public class MessageEventArgs : Object
	{
		// Token: 0x06001988 RID: 6536 RVA: 0x00061D1C File Offset: 0x0005FF1C
		// Note: this type is marked as 'beforefieldinit'.
		static MessageEventArgs()
		{
			Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Networking.PlayerConnection", "MessageEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr);
			MessageEventArgs.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr, "playerId");
			MessageEventArgs.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr, "data");
			MessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr, 100665645);
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00061D88 File Offset: 0x0005FF88
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x0000D6DE File Offset: 0x0000B8DE
		public MessageEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x00061DC4 File Offset: 0x0005FFC4
		// (set) Token: 0x0600198C RID: 6540 RVA: 0x0000D6E7 File Offset: 0x0000B8E7
		public unsafe int playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_playerId)) = value;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x00061DEC File Offset: 0x0005FFEC
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x0000D702 File Offset: 0x0000B902
		public unsafe Il2CppStructArray<byte> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeFieldInfoPtr_playerId;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
