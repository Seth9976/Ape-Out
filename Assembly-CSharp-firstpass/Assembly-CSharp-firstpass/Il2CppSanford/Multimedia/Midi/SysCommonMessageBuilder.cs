using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001B4 RID: 436
	public class SysCommonMessageBuilder : Object
	{
		// Token: 0x060014C8 RID: 5320 RVA: 0x0005FA48 File Offset: 0x0005DC48
		// Note: this type is marked as 'beforefieldinit'.
		static SysCommonMessageBuilder()
		{
			Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "SysCommonMessageBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr);
			SysCommonMessageBuilder.NativeFieldInfoPtr_messageCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, "messageCache");
			SysCommonMessageBuilder.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, "message");
			SysCommonMessageBuilder.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, "result");
			SysCommonMessageBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, 100666245);
			SysCommonMessageBuilder.NativeMethodInfoPtr__ctor_Public_Void_SysCommonMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, 100666246);
			SysCommonMessageBuilder.NativeMethodInfoPtr_Initialize_Public_Void_SysCommonMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, 100666247);
			SysCommonMessageBuilder.NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, 100666248);
			SysCommonMessageBuilder.NativeMethodInfoPtr_get_Count_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, 100666249);
			SysCommonMessageBuilder.NativeMethodInfoPtr_get_Result_Public_get_SysCommonMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, 100666250);
			SysCommonMessageBuilder.NativeMethodInfoPtr_get_Message_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, 100666251);
			SysCommonMessageBuilder.NativeMethodInfoPtr_set_Message_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, 100666252);
			SysCommonMessageBuilder.NativeMethodInfoPtr_get_Type_Public_get_SysCommonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, 100666253);
			SysCommonMessageBuilder.NativeMethodInfoPtr_set_Type_Public_set_Void_SysCommonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, 100666254);
			SysCommonMessageBuilder.NativeMethodInfoPtr_get_Data1_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, 100666255);
			SysCommonMessageBuilder.NativeMethodInfoPtr_set_Data1_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, 100666256);
			SysCommonMessageBuilder.NativeMethodInfoPtr_get_Data2_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, 100666257);
			SysCommonMessageBuilder.NativeMethodInfoPtr_set_Data2_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, 100666258);
			SysCommonMessageBuilder.NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr, 100666259);
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0005FBE0 File Offset: 0x0005DDE0
		[CallerCount(0)]
		public unsafe SysCommonMessageBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x0005FC1C File Offset: 0x0005DE1C
		[CallerCount(0)]
		public unsafe SysCommonMessageBuilder(SysCommonMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SysCommonMessageBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageBuilder.NativeMethodInfoPtr__ctor_Public_Void_SysCommonMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0005FC68 File Offset: 0x0005DE68
		[CallerCount(0)]
		public unsafe void Initialize(SysCommonMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageBuilder.NativeMethodInfoPtr_Initialize_Public_Void_SysCommonMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0005FCAC File Offset: 0x0005DEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16308, XrefRangeEnd = 16313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageBuilder.NativeMethodInfoPtr_Clear_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x0005FCD4 File Offset: 0x0005DED4
		public unsafe static int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16313, XrefRangeEnd = 16318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageBuilder.NativeMethodInfoPtr_get_Count_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x0005FD04 File Offset: 0x0005DF04
		public unsafe SysCommonMessage Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageBuilder.NativeMethodInfoPtr_get_Result_Public_get_SysCommonMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SysCommonMessage>(intPtr3) : null;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x0005FD44 File Offset: 0x0005DF44
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x0005FD80 File Offset: 0x0005DF80
		public unsafe int Message
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageBuilder.NativeMethodInfoPtr_get_Message_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageBuilder.NativeMethodInfoPtr_set_Message_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x0005FDC0 File Offset: 0x0005DFC0
		// (set) Token: 0x060014D2 RID: 5330 RVA: 0x0005FDFC File Offset: 0x0005DFFC
		public unsafe SysCommonType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageBuilder.NativeMethodInfoPtr_get_Type_Public_get_SysCommonType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16318, XrefRangeEnd = 16319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageBuilder.NativeMethodInfoPtr_set_Type_Public_set_Void_SysCommonType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x0005FE3C File Offset: 0x0005E03C
		// (set) Token: 0x060014D4 RID: 5332 RVA: 0x0005FE78 File Offset: 0x0005E078
		public unsafe int Data1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageBuilder.NativeMethodInfoPtr_get_Data1_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageBuilder.NativeMethodInfoPtr_set_Data1_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x0005FEB8 File Offset: 0x0005E0B8
		// (set) Token: 0x060014D6 RID: 5334 RVA: 0x0005FEF4 File Offset: 0x0005E0F4
		public unsafe int Data2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageBuilder.NativeMethodInfoPtr_get_Data2_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageBuilder.NativeMethodInfoPtr_set_Data2_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0005FF34 File Offset: 0x0005E134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16335, RefRangeEnd = 16337, XrefRangeStart = 16319, XrefRangeEnd = 16335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessageBuilder.NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x000087A5 File Offset: 0x000069A5
		public SysCommonMessageBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x0005FF68 File Offset: 0x0005E168
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x000087AE File Offset: 0x000069AE
		public unsafe static Hashtable messageCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SysCommonMessageBuilder.NativeFieldInfoPtr_messageCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysCommonMessageBuilder.NativeFieldInfoPtr_messageCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x0005FF90 File Offset: 0x0005E190
		// (set) Token: 0x060014DC RID: 5340 RVA: 0x000087C0 File Offset: 0x000069C0
		public unsafe int message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SysCommonMessageBuilder.NativeFieldInfoPtr_message);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SysCommonMessageBuilder.NativeFieldInfoPtr_message)) = value;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x0005FFB8 File Offset: 0x0005E1B8
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x000087DB File Offset: 0x000069DB
		public unsafe SysCommonMessage result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SysCommonMessageBuilder.NativeFieldInfoPtr_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysCommonMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SysCommonMessageBuilder.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeFieldInfoPtr_messageCache;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SysCommonMessage_0;

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_SysCommonMessage_0;

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Static_get_Int32_0;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_SysCommonMessage_0;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Internal_get_Int32_0;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeMethodInfoPtr_set_Message_Internal_set_Void_Int32_0;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_SysCommonType_0;

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_SysCommonType_0;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeMethodInfoPtr_get_Data1_Public_get_Int32_0;

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeMethodInfoPtr_set_Data1_Public_set_Void_Int32_0;

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeMethodInfoPtr_get_Data2_Public_get_Int32_0;

		// Token: 0x040016D6 RID: 5846
		private static readonly IntPtr NativeMethodInfoPtr_set_Data2_Public_set_Void_Int32_0;

		// Token: 0x040016D7 RID: 5847
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0;
	}
}
