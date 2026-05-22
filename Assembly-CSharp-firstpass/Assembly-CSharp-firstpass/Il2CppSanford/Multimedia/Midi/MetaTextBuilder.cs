using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001B2 RID: 434
	public class MetaTextBuilder : Object
	{
		// Token: 0x06001499 RID: 5273 RVA: 0x0005EFFC File Offset: 0x0005D1FC
		// Note: this type is marked as 'beforefieldinit'.
		static MetaTextBuilder()
		{
			Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MetaTextBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr);
			MetaTextBuilder.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, "text");
			MetaTextBuilder.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, "type");
			MetaTextBuilder.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, "result");
			MetaTextBuilder.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, "changed");
			MetaTextBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, 100666222);
			MetaTextBuilder.NativeMethodInfoPtr__ctor_Public_Void_MetaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, 100666223);
			MetaTextBuilder.NativeMethodInfoPtr__ctor_Public_Void_MetaType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, 100666224);
			MetaTextBuilder.NativeMethodInfoPtr__ctor_Public_Void_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, 100666225);
			MetaTextBuilder.NativeMethodInfoPtr_Initialize_Public_Void_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, 100666226);
			MetaTextBuilder.NativeMethodInfoPtr_IsTextType_Private_Boolean_MetaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, 100666227);
			MetaTextBuilder.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, 100666228);
			MetaTextBuilder.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, 100666229);
			MetaTextBuilder.NativeMethodInfoPtr_get_Type_Public_get_MetaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, 100666230);
			MetaTextBuilder.NativeMethodInfoPtr_set_Type_Public_set_Void_MetaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, 100666231);
			MetaTextBuilder.NativeMethodInfoPtr_get_Result_Public_get_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, 100666232);
			MetaTextBuilder.NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr, 100666233);
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0005F16C File Offset: 0x0005D36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16264, XrefRangeEnd = 16266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetaTextBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTextBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x0005F1A8 File Offset: 0x0005D3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16266, XrefRangeEnd = 16268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetaTextBuilder(MetaType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTextBuilder.NativeMethodInfoPtr__ctor_Public_Void_MetaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x0005F1F0 File Offset: 0x0005D3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16268, XrefRangeEnd = 16279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetaTextBuilder(MetaType type, string text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTextBuilder.NativeMethodInfoPtr__ctor_Public_Void_MetaType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x0005F24C File Offset: 0x0005D44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16279, XrefRangeEnd = 16283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetaTextBuilder(MetaMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaTextBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTextBuilder.NativeMethodInfoPtr__ctor_Public_Void_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x0005F298 File Offset: 0x0005D498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16283, XrefRangeEnd = 16287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(MetaMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTextBuilder.NativeMethodInfoPtr_Initialize_Public_Void_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x0005F2DC File Offset: 0x0005D4DC
		[CallerCount(0)]
		public unsafe bool IsTextType(MetaType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTextBuilder.NativeMethodInfoPtr_IsTextType_Private_Boolean_MetaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x0005F328 File Offset: 0x0005D528
		// (set) Token: 0x060014A1 RID: 5281 RVA: 0x0005F360 File Offset: 0x0005D560
		public unsafe string Text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTextBuilder.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16287, XrefRangeEnd = 16289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTextBuilder.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x0005F3A4 File Offset: 0x0005D5A4
		// (set) Token: 0x060014A3 RID: 5283 RVA: 0x0005F3E0 File Offset: 0x0005D5E0
		public unsafe MetaType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTextBuilder.NativeMethodInfoPtr_get_Type_Public_get_MetaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTextBuilder.NativeMethodInfoPtr_set_Type_Public_set_Void_MetaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x0005F420 File Offset: 0x0005D620
		public unsafe MetaMessage Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTextBuilder.NativeMethodInfoPtr_get_Result_Public_get_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MetaMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x0005F460 File Offset: 0x0005D660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16289, XrefRangeEnd = 16296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTextBuilder.NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x000086A0 File Offset: 0x000068A0
		public MetaTextBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x0005F494 File Offset: 0x0005D694
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x000086A9 File Offset: 0x000068A9
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaTextBuilder.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaTextBuilder.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x0005F4BC File Offset: 0x0005D6BC
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x000086C8 File Offset: 0x000068C8
		public unsafe MetaType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaTextBuilder.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaTextBuilder.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x0005F4E4 File Offset: 0x0005D6E4
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x000086E3 File Offset: 0x000068E3
		public unsafe MetaMessage result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaTextBuilder.NativeFieldInfoPtr_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetaMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaTextBuilder.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x0005F514 File Offset: 0x0005D714
		// (set) Token: 0x060014AE RID: 5294 RVA: 0x00008702 File Offset: 0x00006902
		public unsafe bool changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaTextBuilder.NativeFieldInfoPtr_changed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaTextBuilder.NativeFieldInfoPtr_changed)) = value;
			}
		}

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeFieldInfoPtr_changed;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MetaType_0;

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MetaType_String_0;

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MetaMessage_0;

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_MetaMessage_0;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeMethodInfoPtr_IsTextType_Private_Boolean_MetaType_0;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_MetaType_0;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_MetaType_0;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_MetaMessage_0;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0;
	}
}
