using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001AF RID: 431
	public class ChannelMessageBuilder : Object
	{
		// Token: 0x06001470 RID: 5232 RVA: 0x0005E684 File Offset: 0x0005C884
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelMessageBuilder()
		{
			Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "ChannelMessageBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr);
			ChannelMessageBuilder.NativeFieldInfoPtr_messageCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, "messageCache");
			ChannelMessageBuilder.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, "message");
			ChannelMessageBuilder.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, "result");
			ChannelMessageBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666196);
			ChannelMessageBuilder.NativeMethodInfoPtr__ctor_Public_Void_ChannelMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666197);
			ChannelMessageBuilder.NativeMethodInfoPtr_Initialize_Public_Void_ChannelMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666198);
			ChannelMessageBuilder.NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666199);
			ChannelMessageBuilder.NativeMethodInfoPtr_get_Count_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666200);
			ChannelMessageBuilder.NativeMethodInfoPtr_get_Result_Public_get_ChannelMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666201);
			ChannelMessageBuilder.NativeMethodInfoPtr_get_Message_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666202);
			ChannelMessageBuilder.NativeMethodInfoPtr_set_Message_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666203);
			ChannelMessageBuilder.NativeMethodInfoPtr_get_Command_Public_get_ChannelCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666204);
			ChannelMessageBuilder.NativeMethodInfoPtr_set_Command_Public_set_Void_ChannelCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666205);
			ChannelMessageBuilder.NativeMethodInfoPtr_get_MidiChannel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666206);
			ChannelMessageBuilder.NativeMethodInfoPtr_set_MidiChannel_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666207);
			ChannelMessageBuilder.NativeMethodInfoPtr_get_Data1_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666208);
			ChannelMessageBuilder.NativeMethodInfoPtr_set_Data1_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666209);
			ChannelMessageBuilder.NativeMethodInfoPtr_get_Data2_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666210);
			ChannelMessageBuilder.NativeMethodInfoPtr_set_Data2_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666211);
			ChannelMessageBuilder.NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr, 100666212);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0005E844 File Offset: 0x0005CA44
		[CallerCount(0)]
		public unsafe ChannelMessageBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0005E880 File Offset: 0x0005CA80
		[CallerCount(0)]
		public unsafe ChannelMessageBuilder(ChannelMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelMessageBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr__ctor_Public_Void_ChannelMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0005E8CC File Offset: 0x0005CACC
		[CallerCount(0)]
		public unsafe void Initialize(ChannelMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr_Initialize_Public_Void_ChannelMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x0005E910 File Offset: 0x0005CB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16205, XrefRangeEnd = 16210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr_Clear_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0005E938 File Offset: 0x0005CB38
		public unsafe static int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16210, XrefRangeEnd = 16215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr_get_Count_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x0005E968 File Offset: 0x0005CB68
		public unsafe ChannelMessage Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr_get_Result_Public_get_ChannelMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChannelMessage>(intPtr3) : null;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x0005E9A8 File Offset: 0x0005CBA8
		// (set) Token: 0x06001478 RID: 5240 RVA: 0x0005E9E4 File Offset: 0x0005CBE4
		public unsafe int Message
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr_get_Message_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr_set_Message_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x0005EA24 File Offset: 0x0005CC24
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x0005EA60 File Offset: 0x0005CC60
		public unsafe ChannelCommand Command
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr_get_Command_Public_get_ChannelCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr_set_Command_Public_set_Void_ChannelCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x0005EAA0 File Offset: 0x0005CCA0
		// (set) Token: 0x0600147C RID: 5244 RVA: 0x0005EADC File Offset: 0x0005CCDC
		public unsafe int MidiChannel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr_get_MidiChannel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16215, XrefRangeEnd = 16216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr_set_MidiChannel_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0005EB1C File Offset: 0x0005CD1C
		// (set) Token: 0x0600147E RID: 5246 RVA: 0x0005EB58 File Offset: 0x0005CD58
		public unsafe int Data1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr_get_Data1_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16216, XrefRangeEnd = 16217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr_set_Data1_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x0005EB98 File Offset: 0x0005CD98
		// (set) Token: 0x06001480 RID: 5248 RVA: 0x0005EBD4 File Offset: 0x0005CDD4
		public unsafe int Data2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr_get_Data2_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16217, XrefRangeEnd = 16218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr_set_Data2_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x0005EC14 File Offset: 0x0005CE14
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 16234, RefRangeEnd = 16239, XrefRangeStart = 16218, XrefRangeEnd = 16234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageBuilder.NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x000085D0 File Offset: 0x000067D0
		public ChannelMessageBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0005EC48 File Offset: 0x0005CE48
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x000085D9 File Offset: 0x000067D9
		public unsafe static Hashtable messageCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelMessageBuilder.NativeFieldInfoPtr_messageCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelMessageBuilder.NativeFieldInfoPtr_messageCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x0005EC70 File Offset: 0x0005CE70
		// (set) Token: 0x06001486 RID: 5254 RVA: 0x000085EB File Offset: 0x000067EB
		public unsafe int message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMessageBuilder.NativeFieldInfoPtr_message);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMessageBuilder.NativeFieldInfoPtr_message)) = value;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x0005EC98 File Offset: 0x0005CE98
		// (set) Token: 0x06001488 RID: 5256 RVA: 0x00008606 File Offset: 0x00006806
		public unsafe ChannelMessage result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMessageBuilder.NativeFieldInfoPtr_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChannelMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMessageBuilder.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001687 RID: 5767
		private static readonly IntPtr NativeFieldInfoPtr_messageCache;

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04001689 RID: 5769
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x0400168A RID: 5770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400168B RID: 5771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ChannelMessage_0;

		// Token: 0x0400168C RID: 5772
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ChannelMessage_0;

		// Token: 0x0400168D RID: 5773
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

		// Token: 0x0400168E RID: 5774
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Static_get_Int32_0;

		// Token: 0x0400168F RID: 5775
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_ChannelMessage_0;

		// Token: 0x04001690 RID: 5776
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Internal_get_Int32_0;

		// Token: 0x04001691 RID: 5777
		private static readonly IntPtr NativeMethodInfoPtr_set_Message_Internal_set_Void_Int32_0;

		// Token: 0x04001692 RID: 5778
		private static readonly IntPtr NativeMethodInfoPtr_get_Command_Public_get_ChannelCommand_0;

		// Token: 0x04001693 RID: 5779
		private static readonly IntPtr NativeMethodInfoPtr_set_Command_Public_set_Void_ChannelCommand_0;

		// Token: 0x04001694 RID: 5780
		private static readonly IntPtr NativeMethodInfoPtr_get_MidiChannel_Public_get_Int32_0;

		// Token: 0x04001695 RID: 5781
		private static readonly IntPtr NativeMethodInfoPtr_set_MidiChannel_Public_set_Void_Int32_0;

		// Token: 0x04001696 RID: 5782
		private static readonly IntPtr NativeMethodInfoPtr_get_Data1_Public_get_Int32_0;

		// Token: 0x04001697 RID: 5783
		private static readonly IntPtr NativeMethodInfoPtr_set_Data1_Public_set_Void_Int32_0;

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeMethodInfoPtr_get_Data2_Public_get_Int32_0;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeMethodInfoPtr_set_Data2_Public_set_Void_Int32_0;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0;
	}
}
