using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x0200019A RID: 410
	public class MidiHeaderBuilder : Object
	{
		// Token: 0x06001354 RID: 4948 RVA: 0x0005AA1C File Offset: 0x00058C1C
		// Note: this type is marked as 'beforefieldinit'.
		static MidiHeaderBuilder()
		{
			Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MidiHeaderBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr);
			MidiHeaderBuilder.NativeFieldInfoPtr_bufferLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr, "bufferLength");
			MidiHeaderBuilder.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr, "data");
			MidiHeaderBuilder.NativeFieldInfoPtr_built = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr, "built");
			MidiHeaderBuilder.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr, "result");
			MidiHeaderBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr, 100666066);
			MidiHeaderBuilder.NativeMethodInfoPtr_Build_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr, 100666067);
			MidiHeaderBuilder.NativeMethodInfoPtr_InitializeBuffer_Public_Void_SysExMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr, 100666068);
			MidiHeaderBuilder.NativeMethodInfoPtr_InitializeBuffer_Public_Void_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr, 100666069);
			MidiHeaderBuilder.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr, 100666070);
			MidiHeaderBuilder.NativeMethodInfoPtr_Destroy_Public_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr, 100666071);
			MidiHeaderBuilder.NativeMethodInfoPtr_get_BufferLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr, 100666072);
			MidiHeaderBuilder.NativeMethodInfoPtr_set_BufferLength_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr, 100666073);
			MidiHeaderBuilder.NativeMethodInfoPtr_get_Result_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr, 100666074);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0005AB50 File Offset: 0x00058D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15480, XrefRangeEnd = 15481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MidiHeaderBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiHeaderBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiHeaderBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0005AB8C File Offset: 0x00058D8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 15512, RefRangeEnd = 15515, XrefRangeStart = 15481, XrefRangeEnd = 15512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiHeaderBuilder.NativeMethodInfoPtr_Build_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0005ABC0 File Offset: 0x00058DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15515, XrefRangeEnd = 15517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeBuffer(SysExMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiHeaderBuilder.NativeMethodInfoPtr_InitializeBuffer_Public_Void_SysExMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0005AC04 File Offset: 0x00058E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15517, XrefRangeEnd = 15526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeBuffer(ICollection events)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(events);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiHeaderBuilder.NativeMethodInfoPtr_InitializeBuffer_Public_Void_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0005AC48 File Offset: 0x00058E48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15533, RefRangeEnd = 15534, XrefRangeStart = 15526, XrefRangeEnd = 15533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiHeaderBuilder.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0005AC7C File Offset: 0x00058E7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 15548, RefRangeEnd = 15551, XrefRangeStart = 15534, XrefRangeEnd = 15548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy(IntPtr headerPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref headerPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiHeaderBuilder.NativeMethodInfoPtr_Destroy_Public_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x0005ACBC File Offset: 0x00058EBC
		// (set) Token: 0x0600135C RID: 4956 RVA: 0x0005ACF8 File Offset: 0x00058EF8
		public unsafe int BufferLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiHeaderBuilder.NativeMethodInfoPtr_get_BufferLength_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 15554, RefRangeEnd = 15564, XrefRangeStart = 15551, XrefRangeEnd = 15554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiHeaderBuilder.NativeMethodInfoPtr_set_BufferLength_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x0005AD38 File Offset: 0x00058F38
		public unsafe IntPtr Result
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiHeaderBuilder.NativeMethodInfoPtr_get_Result_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00007F4E File Offset: 0x0000614E
		public MidiHeaderBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x0005AD74 File Offset: 0x00058F74
		// (set) Token: 0x06001360 RID: 4960 RVA: 0x00007F57 File Offset: 0x00006157
		public unsafe int bufferLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeaderBuilder.NativeFieldInfoPtr_bufferLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeaderBuilder.NativeFieldInfoPtr_bufferLength)) = value;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x0005AD9C File Offset: 0x00058F9C
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x00007F72 File Offset: 0x00006172
		public unsafe Il2CppStructArray<byte> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeaderBuilder.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeaderBuilder.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x0005ADCC File Offset: 0x00058FCC
		// (set) Token: 0x06001364 RID: 4964 RVA: 0x00007F91 File Offset: 0x00006191
		public unsafe bool built
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeaderBuilder.NativeFieldInfoPtr_built);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeaderBuilder.NativeFieldInfoPtr_built)) = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x0005ADF4 File Offset: 0x00058FF4
		// (set) Token: 0x06001366 RID: 4966 RVA: 0x00007FAC File Offset: 0x000061AC
		public unsafe IntPtr result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeaderBuilder.NativeFieldInfoPtr_result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeaderBuilder.NativeFieldInfoPtr_result)) = value;
			}
		}

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeFieldInfoPtr_bufferLength;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeFieldInfoPtr_built;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Void_0;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeMethodInfoPtr_InitializeBuffer_Public_Void_SysExMessage_0;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeMethodInfoPtr_InitializeBuffer_Public_Void_ICollection_0;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_IntPtr_0;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeMethodInfoPtr_get_BufferLength_Public_get_Int32_0;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeMethodInfoPtr_set_BufferLength_Public_set_Void_Int32_0;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_IntPtr_0;
	}
}
