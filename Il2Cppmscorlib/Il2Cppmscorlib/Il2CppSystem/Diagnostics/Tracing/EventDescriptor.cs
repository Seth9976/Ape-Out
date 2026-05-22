using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000512 RID: 1298
	[StructLayout(2)]
	public struct EventDescriptor
	{
		// Token: 0x06004C52 RID: 19538 RVA: 0x00160658 File Offset: 0x0015E858
		// Note: this type is marked as 'beforefieldinit'.
		static EventDescriptor()
		{
			Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr);
			EventDescriptor.NativeFieldInfoPtr_m_traceloggingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_traceloggingId");
			EventDescriptor.NativeFieldInfoPtr_m_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_id");
			EventDescriptor.NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_version");
			EventDescriptor.NativeFieldInfoPtr_m_channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_channel");
			EventDescriptor.NativeFieldInfoPtr_m_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_level");
			EventDescriptor.NativeFieldInfoPtr_m_opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_opcode");
			EventDescriptor.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_task");
			EventDescriptor.NativeFieldInfoPtr_m_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_keywords");
			EventDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Byte_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674719);
			EventDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Byte_Byte_Byte_Byte_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674720);
			EventDescriptor.NativeMethodInfoPtr_get_EventId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674721);
			EventDescriptor.NativeMethodInfoPtr_get_Version_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674722);
			EventDescriptor.NativeMethodInfoPtr_get_Channel_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674723);
			EventDescriptor.NativeMethodInfoPtr_get_Level_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674724);
			EventDescriptor.NativeMethodInfoPtr_get_Opcode_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674725);
			EventDescriptor.NativeMethodInfoPtr_get_Task_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674726);
			EventDescriptor.NativeMethodInfoPtr_get_Keywords_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674727);
			EventDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674728);
			EventDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674729);
			EventDescriptor.NativeMethodInfoPtr_Equals_Public_Boolean_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674730);
		}

		// Token: 0x06004C53 RID: 19539 RVA: 0x00160818 File Offset: 0x0015EA18
		[CallerCount(0)]
		public unsafe EventDescriptor(int traceloggingId, byte level, byte opcode, long keywords)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceloggingId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opcode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywords;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Byte_Byte_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C54 RID: 19540 RVA: 0x00160874 File Offset: 0x0015EA74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 240725, RefRangeEnd = 240728, XrefRangeStart = 240725, XrefRangeEnd = 240725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDescriptor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opcode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref task;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywords;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Byte_Byte_Byte_Byte_Int32_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06004C55 RID: 19541 RVA: 0x001608FC File Offset: 0x0015EAFC
		public unsafe int EventId
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_get_EventId_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06004C56 RID: 19542 RVA: 0x0016092C File Offset: 0x0015EB2C
		public unsafe byte Version
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_get_Version_Public_get_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06004C57 RID: 19543 RVA: 0x0016095C File Offset: 0x0015EB5C
		public unsafe byte Channel
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_get_Channel_Public_get_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06004C58 RID: 19544 RVA: 0x0016098C File Offset: 0x0015EB8C
		public unsafe byte Level
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_get_Level_Public_get_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06004C59 RID: 19545 RVA: 0x001609BC File Offset: 0x0015EBBC
		public unsafe byte Opcode
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_get_Opcode_Public_get_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06004C5A RID: 19546 RVA: 0x001609EC File Offset: 0x0015EBEC
		public unsafe int Task
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_get_Task_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06004C5B RID: 19547 RVA: 0x00160A1C File Offset: 0x0015EC1C
		public unsafe long Keywords
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_get_Keywords_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x00160A4C File Offset: 0x0015EC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240728, XrefRangeEnd = 240730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x00160A90 File Offset: 0x0015EC90
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x00160AC0 File Offset: 0x0015ECC0
		[CallerCount(0)]
		public unsafe bool Equals(EventDescriptor other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_Equals_Public_Boolean_EventDescriptor_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x0001C575 File Offset: 0x0001A775
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, ref this));
		}

		// Token: 0x04003D9E RID: 15774
		private static readonly IntPtr NativeFieldInfoPtr_m_traceloggingId;

		// Token: 0x04003D9F RID: 15775
		private static readonly IntPtr NativeFieldInfoPtr_m_id;

		// Token: 0x04003DA0 RID: 15776
		private static readonly IntPtr NativeFieldInfoPtr_m_version;

		// Token: 0x04003DA1 RID: 15777
		private static readonly IntPtr NativeFieldInfoPtr_m_channel;

		// Token: 0x04003DA2 RID: 15778
		private static readonly IntPtr NativeFieldInfoPtr_m_level;

		// Token: 0x04003DA3 RID: 15779
		private static readonly IntPtr NativeFieldInfoPtr_m_opcode;

		// Token: 0x04003DA4 RID: 15780
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x04003DA5 RID: 15781
		private static readonly IntPtr NativeFieldInfoPtr_m_keywords;

		// Token: 0x04003DA6 RID: 15782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Byte_Byte_Int64_0;

		// Token: 0x04003DA7 RID: 15783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Byte_Byte_Byte_Byte_Int32_Int64_0;

		// Token: 0x04003DA8 RID: 15784
		private static readonly IntPtr NativeMethodInfoPtr_get_EventId_Public_get_Int32_0;

		// Token: 0x04003DA9 RID: 15785
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Byte_0;

		// Token: 0x04003DAA RID: 15786
		private static readonly IntPtr NativeMethodInfoPtr_get_Channel_Public_get_Byte_0;

		// Token: 0x04003DAB RID: 15787
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Public_get_Byte_0;

		// Token: 0x04003DAC RID: 15788
		private static readonly IntPtr NativeMethodInfoPtr_get_Opcode_Public_get_Byte_0;

		// Token: 0x04003DAD RID: 15789
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Public_get_Int32_0;

		// Token: 0x04003DAE RID: 15790
		private static readonly IntPtr NativeMethodInfoPtr_get_Keywords_Public_get_Int64_0;

		// Token: 0x04003DAF RID: 15791
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003DB0 RID: 15792
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003DB1 RID: 15793
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_EventDescriptor_0;

		// Token: 0x04003DB2 RID: 15794
		[FieldOffset(0)]
		public int m_traceloggingId;

		// Token: 0x04003DB3 RID: 15795
		[FieldOffset(0)]
		public ushort m_id;

		// Token: 0x04003DB4 RID: 15796
		[FieldOffset(2)]
		public byte m_version;

		// Token: 0x04003DB5 RID: 15797
		[FieldOffset(3)]
		public byte m_channel;

		// Token: 0x04003DB6 RID: 15798
		[FieldOffset(4)]
		public byte m_level;

		// Token: 0x04003DB7 RID: 15799
		[FieldOffset(5)]
		public byte m_opcode;

		// Token: 0x04003DB8 RID: 15800
		[FieldOffset(6)]
		public ushort m_task;

		// Token: 0x04003DB9 RID: 15801
		[FieldOffset(8)]
		public long m_keywords;
	}
}
