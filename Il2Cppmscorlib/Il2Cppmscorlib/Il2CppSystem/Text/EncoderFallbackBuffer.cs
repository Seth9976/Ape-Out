using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x0200016A RID: 362
	public class EncoderFallbackBuffer : Object
	{
		// Token: 0x06001893 RID: 6291 RVA: 0x00092D0C File Offset: 0x00090F0C
		// Note: this type is marked as 'beforefieldinit'.
		static EncoderFallbackBuffer()
		{
			Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr);
			EncoderFallbackBuffer.NativeFieldInfoPtr_charStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "charStart");
			EncoderFallbackBuffer.NativeFieldInfoPtr_charEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "charEnd");
			EncoderFallbackBuffer.NativeFieldInfoPtr_encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "encoder");
			EncoderFallbackBuffer.NativeFieldInfoPtr_setEncoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "setEncoder");
			EncoderFallbackBuffer.NativeFieldInfoPtr_bUsedEncoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "bUsedEncoder");
			EncoderFallbackBuffer.NativeFieldInfoPtr_bFallingBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "bFallingBack");
			EncoderFallbackBuffer.NativeFieldInfoPtr_iRecursionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "iRecursionCount");
			EncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667436);
			EncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667437);
			EncoderFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Abstract_Virtual_New_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667438);
			EncoderFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667439);
			EncoderFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667440);
			EncoderFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667441);
			EncoderFallbackBuffer.NativeMethodInfoPtr_InternalReset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667442);
			EncoderFallbackBuffer.NativeMethodInfoPtr_InternalInitialize_Internal_Void_ptr_Char_ptr_Char_EncoderNLS_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667443);
			EncoderFallbackBuffer.NativeMethodInfoPtr_InternalGetNextChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667444);
			EncoderFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Boolean_Char_byref_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667445);
			EncoderFallbackBuffer.NativeMethodInfoPtr_ThrowLastCharRecursive_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667446);
			EncoderFallbackBuffer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667447);
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00092EB8 File Offset: 0x000910B8
		[CallerCount(0)]
		public unsafe virtual bool Fallback(char charUnknown, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknown;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00092F1C File Offset: 0x0009111C
		[CallerCount(0)]
		public unsafe virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknownHigh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknownLow;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00092F8C File Offset: 0x0009118C
		[CallerCount(0)]
		public unsafe virtual char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Abstract_Virtual_New_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00092FD4 File Offset: 0x000911D4
		[CallerCount(0)]
		public unsafe virtual bool MovePrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x0009301C File Offset: 0x0009121C
		public unsafe virtual int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00093064 File Offset: 0x00091264
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x000930A0 File Offset: 0x000912A0
		[CallerCount(0)]
		public unsafe void InternalReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackBuffer.NativeMethodInfoPtr_InternalReset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x000930D4 File Offset: 0x000912D4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 179759, RefRangeEnd = 179773, XrefRangeStart = 179759, XrefRangeEnd = 179759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = charStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = charEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setEncoder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackBuffer.NativeMethodInfoPtr_InternalInitialize_Internal_Void_ptr_Char_ptr_Char_EncoderNLS_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00093140 File Offset: 0x00091340
		[CallerCount(0)]
		public unsafe char InternalGetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackBuffer.NativeMethodInfoPtr_InternalGetNextChar_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x0009317C File Offset: 0x0009137C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179773, XrefRangeEnd = 179780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool InternalFallback(char ch, ref char* chars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Boolean_Char_byref_ptr_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chars = ((intPtr4 == 0) ? null : new char*(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x000931FC File Offset: 0x000913FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179780, XrefRangeEnd = 179795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowLastCharRecursive(int charRecursive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charRecursive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackBuffer.NativeMethodInfoPtr_ThrowLastCharRecursive_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0009323C File Offset: 0x0009143C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallbackBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackBuffer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x000087F1 File Offset: 0x000069F1
		public EncoderFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x00093278 File Offset: 0x00091478
		// (set) Token: 0x060018A2 RID: 6306 RVA: 0x000087FA File Offset: 0x000069FA
		public unsafe char* charStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_charStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_charStart)) = value;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x0009329C File Offset: 0x0009149C
		// (set) Token: 0x060018A4 RID: 6308 RVA: 0x00008815 File Offset: 0x00006A15
		public unsafe char* charEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_charEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_charEnd)) = value;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x000932C0 File Offset: 0x000914C0
		// (set) Token: 0x060018A6 RID: 6310 RVA: 0x00008830 File Offset: 0x00006A30
		public unsafe EncoderNLS encoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_encoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderNLS>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_encoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x000932F0 File Offset: 0x000914F0
		// (set) Token: 0x060018A8 RID: 6312 RVA: 0x0000884F File Offset: 0x00006A4F
		public unsafe bool setEncoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_setEncoder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_setEncoder)) = value;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x00093318 File Offset: 0x00091518
		// (set) Token: 0x060018AA RID: 6314 RVA: 0x0000886A File Offset: 0x00006A6A
		public unsafe bool bUsedEncoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_bUsedEncoder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_bUsedEncoder)) = value;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x00093340 File Offset: 0x00091540
		// (set) Token: 0x060018AC RID: 6316 RVA: 0x00008885 File Offset: 0x00006A85
		public unsafe bool bFallingBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_bFallingBack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_bFallingBack)) = value;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x00093368 File Offset: 0x00091568
		// (set) Token: 0x060018AE RID: 6318 RVA: 0x000088A0 File Offset: 0x00006AA0
		public unsafe int iRecursionCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_iRecursionCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_iRecursionCount)) = value;
			}
		}

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeFieldInfoPtr_charStart;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeFieldInfoPtr_charEnd;

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeFieldInfoPtr_encoder;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeFieldInfoPtr_setEncoder;

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeFieldInfoPtr_bUsedEncoder;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeFieldInfoPtr_bFallingBack;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeFieldInfoPtr_iRecursionCount;

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Int32_0;

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Char_Int32_0;

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Abstract_Virtual_New_Char_0;

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeMethodInfoPtr_MovePrevious_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeMethodInfoPtr_InternalReset_Internal_Void_0;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeMethodInfoPtr_InternalInitialize_Internal_Void_ptr_Char_ptr_Char_EncoderNLS_Boolean_0;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetNextChar_Internal_Char_0;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Boolean_Char_byref_ptr_Char_0;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeMethodInfoPtr_ThrowLastCharRecursive_Internal_Void_Int32_0;

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
