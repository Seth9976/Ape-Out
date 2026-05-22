using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000021 RID: 33
	public class CharEntityEncoderFallback : EncoderFallback
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x00019F2C File Offset: 0x0001812C
		// Note: this type is marked as 'beforefieldinit'.
		static CharEntityEncoderFallback()
		{
			Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "CharEntityEncoderFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr);
			CharEntityEncoderFallback.NativeFieldInfoPtr_fallbackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, "fallbackBuffer");
			CharEntityEncoderFallback.NativeFieldInfoPtr_textContentMarks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, "textContentMarks");
			CharEntityEncoderFallback.NativeFieldInfoPtr_endMarkPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, "endMarkPos");
			CharEntityEncoderFallback.NativeFieldInfoPtr_curMarkPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, "curMarkPos");
			CharEntityEncoderFallback.NativeFieldInfoPtr_startOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, "startOffset");
			CharEntityEncoderFallback.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, 100663482);
			CharEntityEncoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, 100663483);
			CharEntityEncoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, 100663484);
			CharEntityEncoderFallback.NativeMethodInfoPtr_set_StartOffset_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, 100663485);
			CharEntityEncoderFallback.NativeMethodInfoPtr_Reset_Internal_Void_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, 100663486);
			CharEntityEncoderFallback.NativeMethodInfoPtr_CanReplaceAt_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, 100663487);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0001A038 File Offset: 0x00018238
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharEntityEncoderFallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEntityEncoderFallback.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0001A074 File Offset: 0x00018274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389717, XrefRangeEnd = 389722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0001A0C0 File Offset: 0x000182C0
		public unsafe override int MaxCharCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (set) Token: 0x060001BD RID: 445 RVA: 0x0001A108 File Offset: 0x00018308
		public unsafe int StartOffset
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEntityEncoderFallback.NativeMethodInfoPtr_set_StartOffset_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0001A148 File Offset: 0x00018348
		[CallerCount(0)]
		public unsafe void Reset(Il2CppStructArray<int> textContentMarks, int endMarkPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textContentMarks);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endMarkPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEntityEncoderFallback.NativeMethodInfoPtr_Reset_Internal_Void_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0001A198 File Offset: 0x00018398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389722, RefRangeEnd = 389723, XrefRangeStart = 389722, XrefRangeEnd = 389722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanReplaceAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEntityEncoderFallback.NativeMethodInfoPtr_CanReplaceAt_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002C58 File Offset: 0x00000E58
		public CharEntityEncoderFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0001A1E4 File Offset: 0x000183E4
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002C61 File Offset: 0x00000E61
		public unsafe CharEntityEncoderFallbackBuffer fallbackBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_fallbackBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharEntityEncoderFallbackBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_fallbackBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0001A214 File Offset: 0x00018414
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002C80 File Offset: 0x00000E80
		public unsafe Il2CppStructArray<int> textContentMarks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_textContentMarks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_textContentMarks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0001A244 File Offset: 0x00018444
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002C9F File Offset: 0x00000E9F
		public unsafe int endMarkPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_endMarkPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_endMarkPos)) = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0001A26C File Offset: 0x0001846C
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002CBA File Offset: 0x00000EBA
		public unsafe int curMarkPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_curMarkPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_curMarkPos)) = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0001A294 File Offset: 0x00018494
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00002CD5 File Offset: 0x00000ED5
		public unsafe int startOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_startOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_startOffset)) = value;
			}
		}

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_fallbackBuffer;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_textContentMarks;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_endMarkPos;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_curMarkPos;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_startOffset;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_set_StartOffset_Internal_set_Void_Int32_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_CanReplaceAt_Internal_Boolean_Int32_0;
	}
}
