using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001C5 RID: 453
	public sealed class SysRealtimeMessage : ShortMessage
	{
		// Token: 0x060015E4 RID: 5604 RVA: 0x00063FC8 File Offset: 0x000621C8
		// Note: this type is marked as 'beforefieldinit'.
		static SysRealtimeMessage()
		{
			Il2CppClassPointerStore<SysRealtimeMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "SysRealtimeMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SysRealtimeMessage>.NativeClassPtr);
			SysRealtimeMessage.NativeFieldInfoPtr_StartMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysRealtimeMessage>.NativeClassPtr, "StartMessage");
			SysRealtimeMessage.NativeFieldInfoPtr_ContinueMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysRealtimeMessage>.NativeClassPtr, "ContinueMessage");
			SysRealtimeMessage.NativeFieldInfoPtr_StopMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysRealtimeMessage>.NativeClassPtr, "StopMessage");
			SysRealtimeMessage.NativeFieldInfoPtr_ClockMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysRealtimeMessage>.NativeClassPtr, "ClockMessage");
			SysRealtimeMessage.NativeFieldInfoPtr_TickMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysRealtimeMessage>.NativeClassPtr, "TickMessage");
			SysRealtimeMessage.NativeFieldInfoPtr_ActiveSenseMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysRealtimeMessage>.NativeClassPtr, "ActiveSenseMessage");
			SysRealtimeMessage.NativeFieldInfoPtr_ResetMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysRealtimeMessage>.NativeClassPtr, "ResetMessage");
			SysRealtimeMessage.NativeMethodInfoPtr__ctor_Private_Void_SysRealtimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysRealtimeMessage>.NativeClassPtr, 100666411);
			SysRealtimeMessage.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysRealtimeMessage>.NativeClassPtr, 100666412);
			SysRealtimeMessage.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysRealtimeMessage>.NativeClassPtr, 100666413);
			SysRealtimeMessage.NativeMethodInfoPtr_get_SysRealtimeType_Public_get_SysRealtimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysRealtimeMessage>.NativeClassPtr, 100666414);
			SysRealtimeMessage.NativeMethodInfoPtr_get_MessageType_Public_Virtual_get_MessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysRealtimeMessage>.NativeClassPtr, 100666415);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x000640E8 File Offset: 0x000622E8
		[CallerCount(0)]
		public unsafe SysRealtimeMessage(SysRealtimeType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SysRealtimeMessage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysRealtimeMessage.NativeMethodInfoPtr__ctor_Private_Void_SysRealtimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00064130 File Offset: 0x00062330
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysRealtimeMessage.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x0006416C File Offset: 0x0006236C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16941, XrefRangeEnd = 16943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysRealtimeMessage.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060015E8 RID: 5608 RVA: 0x000641BC File Offset: 0x000623BC
		public unsafe SysRealtimeType SysRealtimeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysRealtimeMessage.NativeMethodInfoPtr_get_SysRealtimeType_Public_get_SysRealtimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x000641F8 File Offset: 0x000623F8
		public unsafe override MessageType MessageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysRealtimeMessage.NativeMethodInfoPtr_get_MessageType_Public_Virtual_get_MessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00008C53 File Offset: 0x00006E53
		public SysRealtimeMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x00064234 File Offset: 0x00062434
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x00008C5C File Offset: 0x00006E5C
		public unsafe static SysRealtimeMessage StartMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SysRealtimeMessage.NativeFieldInfoPtr_StartMessage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessage>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysRealtimeMessage.NativeFieldInfoPtr_StartMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x0006425C File Offset: 0x0006245C
		// (set) Token: 0x060015EE RID: 5614 RVA: 0x00008C6E File Offset: 0x00006E6E
		public unsafe static SysRealtimeMessage ContinueMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SysRealtimeMessage.NativeFieldInfoPtr_ContinueMessage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessage>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysRealtimeMessage.NativeFieldInfoPtr_ContinueMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x00064284 File Offset: 0x00062484
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x00008C80 File Offset: 0x00006E80
		public unsafe static SysRealtimeMessage StopMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SysRealtimeMessage.NativeFieldInfoPtr_StopMessage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessage>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysRealtimeMessage.NativeFieldInfoPtr_StopMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x000642AC File Offset: 0x000624AC
		// (set) Token: 0x060015F2 RID: 5618 RVA: 0x00008C92 File Offset: 0x00006E92
		public unsafe static SysRealtimeMessage ClockMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SysRealtimeMessage.NativeFieldInfoPtr_ClockMessage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessage>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysRealtimeMessage.NativeFieldInfoPtr_ClockMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x000642D4 File Offset: 0x000624D4
		// (set) Token: 0x060015F4 RID: 5620 RVA: 0x00008CA4 File Offset: 0x00006EA4
		public unsafe static SysRealtimeMessage TickMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SysRealtimeMessage.NativeFieldInfoPtr_TickMessage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessage>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysRealtimeMessage.NativeFieldInfoPtr_TickMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060015F5 RID: 5621 RVA: 0x000642FC File Offset: 0x000624FC
		// (set) Token: 0x060015F6 RID: 5622 RVA: 0x00008CB6 File Offset: 0x00006EB6
		public unsafe static SysRealtimeMessage ActiveSenseMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SysRealtimeMessage.NativeFieldInfoPtr_ActiveSenseMessage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessage>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysRealtimeMessage.NativeFieldInfoPtr_ActiveSenseMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x00064324 File Offset: 0x00062524
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x00008CC8 File Offset: 0x00006EC8
		public unsafe static SysRealtimeMessage ResetMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SysRealtimeMessage.NativeFieldInfoPtr_ResetMessage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessage>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysRealtimeMessage.NativeFieldInfoPtr_ResetMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeFieldInfoPtr_StartMessage;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeFieldInfoPtr_ContinueMessage;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeFieldInfoPtr_StopMessage;

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeFieldInfoPtr_ClockMessage;

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeFieldInfoPtr_TickMessage;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeFieldInfoPtr_ActiveSenseMessage;

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeFieldInfoPtr_ResetMessage;

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SysRealtimeType_0;

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeMethodInfoPtr_get_SysRealtimeType_Public_get_SysRealtimeType_0;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageType_Public_Virtual_get_MessageType_0;
	}
}
