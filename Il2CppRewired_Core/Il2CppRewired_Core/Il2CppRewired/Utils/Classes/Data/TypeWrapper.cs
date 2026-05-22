using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001C0 RID: 448
	public sealed class TypeWrapper : ValueType
	{
		// Token: 0x06002F04 RID: 12036 RVA: 0x000EA214 File Offset: 0x000E8414
		// Note: this type is marked as 'beforefieldinit'.
		static TypeWrapper()
		{
			Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "TypeWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr);
			TypeWrapper.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, "type");
			TypeWrapper.NativeFieldInfoPtr_CAptIFwjKcXIZCyiVWOUrBjngNpa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, "CAptIFwjKcXIZCyiVWOUrBjngNpa");
			TypeWrapper.NativeFieldInfoPtr_klMJYsQTpJWiuMmAwxgajgMtIPx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, "klMJYsQTpJWiuMmAwxgajgMtIPx");
			TypeWrapper.NativeFieldInfoPtr_TohavlHiixXcKvkPOcULdxnTJjh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, "TohavlHiixXcKvkPOcULdxnTJjh");
			TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675402);
			TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675403);
			TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675404);
			TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675405);
			TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675406);
			TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675407);
			TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675408);
			TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675409);
			TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675410);
			TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675411);
			TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675412);
			TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675413);
			TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675414);
			TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675415);
			TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675416);
			TypeWrapper.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675417);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_TypeWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675418);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_SByte_TypeWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675419);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Char_TypeWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675420);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Int16_TypeWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675421);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_TypeWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675422);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Int64_TypeWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675423);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_TypeWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675424);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_TypeWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675425);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_TypeWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675426);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_TypeWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675427);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Double_TypeWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675428);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_TypeWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675429);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_String_TypeWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675430);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675431);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675432);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675433);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675434);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675435);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675436);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675437);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675438);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675439);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675440);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675441);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675442);
			TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, 100675443);
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x000EA5DC File Offset: 0x000E87DC
		[CallerCount(0)]
		public unsafe TypeWrapper(TypeWrapper.DataType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_DataType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x000EA628 File Offset: 0x000E8828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334930, RefRangeEnd = 334932, XrefRangeStart = 334930, XrefRangeEnd = 334930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeWrapper(byte item)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x000EA674 File Offset: 0x000E8874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334932, RefRangeEnd = 334934, XrefRangeStart = 334932, XrefRangeEnd = 334932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeWrapper(sbyte item)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_SByte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x000EA6C0 File Offset: 0x000E88C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334934, RefRangeEnd = 334936, XrefRangeStart = 334934, XrefRangeEnd = 334934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeWrapper(char item)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x000EA70C File Offset: 0x000E890C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334936, RefRangeEnd = 334937, XrefRangeStart = 334936, XrefRangeEnd = 334936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeWrapper(short item)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Int16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x000EA758 File Offset: 0x000E8958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334937, RefRangeEnd = 334938, XrefRangeStart = 334937, XrefRangeEnd = 334937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeWrapper(ushort item)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_UInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x000EA7A4 File Offset: 0x000E89A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334938, RefRangeEnd = 334940, XrefRangeStart = 334938, XrefRangeEnd = 334938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeWrapper(int item)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x000EA7F0 File Offset: 0x000E89F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334940, RefRangeEnd = 334942, XrefRangeStart = 334940, XrefRangeEnd = 334940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeWrapper(uint item)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x000EA83C File Offset: 0x000E8A3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334942, RefRangeEnd = 334944, XrefRangeStart = 334942, XrefRangeEnd = 334942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeWrapper(long item)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x000EA888 File Offset: 0x000E8A88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334944, RefRangeEnd = 334946, XrefRangeStart = 334944, XrefRangeEnd = 334944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeWrapper(ulong item)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x000EA8D4 File Offset: 0x000E8AD4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 334946, RefRangeEnd = 334953, XrefRangeStart = 334946, XrefRangeEnd = 334946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeWrapper(float item)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x000EA920 File Offset: 0x000E8B20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334953, RefRangeEnd = 334955, XrefRangeStart = 334953, XrefRangeEnd = 334953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeWrapper(double item)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x000EA96C File Offset: 0x000E8B6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334955, RefRangeEnd = 334957, XrefRangeStart = 334955, XrefRangeEnd = 334955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeWrapper(bool item)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x000EA9B8 File Offset: 0x000E8BB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334957, RefRangeEnd = 334959, XrefRangeStart = 334957, XrefRangeEnd = 334957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeWrapper(string item)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x000EAA08 File Offset: 0x000E8C08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334959, RefRangeEnd = 334960, XrefRangeStart = 334959, XrefRangeEnd = 334959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeWrapper(Object item)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x000EAA58 File Offset: 0x000E8C58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 334960, RefRangeEnd = 334965, XrefRangeStart = 334960, XrefRangeEnd = 334960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x000EAA90 File Offset: 0x000E8C90
		[CallerCount(0)]
		public unsafe static implicit operator byte(TypeWrapper obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_TypeWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x000EAAD8 File Offset: 0x000E8CD8
		[CallerCount(0)]
		public unsafe static implicit operator sbyte(TypeWrapper obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_SByte_TypeWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x000EAB20 File Offset: 0x000E8D20
		[CallerCount(0)]
		public unsafe static implicit operator char(TypeWrapper obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Char_TypeWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x000EAB68 File Offset: 0x000E8D68
		[CallerCount(0)]
		public unsafe static implicit operator short(TypeWrapper obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Int16_TypeWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x000EABB0 File Offset: 0x000E8DB0
		[CallerCount(0)]
		public unsafe static implicit operator int(TypeWrapper obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_TypeWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x000EABF8 File Offset: 0x000E8DF8
		[CallerCount(0)]
		public unsafe static implicit operator long(TypeWrapper obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Int64_TypeWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x000EAC40 File Offset: 0x000E8E40
		[CallerCount(0)]
		public unsafe static implicit operator ushort(TypeWrapper obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_TypeWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x000EAC88 File Offset: 0x000E8E88
		[CallerCount(0)]
		public unsafe static implicit operator uint(TypeWrapper obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_TypeWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x000EACD0 File Offset: 0x000E8ED0
		[CallerCount(0)]
		public unsafe static implicit operator ulong(TypeWrapper obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_TypeWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x000EAD18 File Offset: 0x000E8F18
		[CallerCount(0)]
		public unsafe static implicit operator float(TypeWrapper obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_TypeWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x000EAD60 File Offset: 0x000E8F60
		[CallerCount(0)]
		public unsafe static implicit operator double(TypeWrapper obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Double_TypeWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x000EADA8 File Offset: 0x000E8FA8
		[CallerCount(0)]
		public unsafe static implicit operator bool(TypeWrapper obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_TypeWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x000EADF0 File Offset: 0x000E8FF0
		[CallerCount(0)]
		public unsafe static implicit operator string(TypeWrapper obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_String_TypeWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x000EAE34 File Offset: 0x000E9034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334965, XrefRangeEnd = 334966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator TypeWrapper(byte obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TypeWrapper(intPtr);
			}
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x000EAE6C File Offset: 0x000E906C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334966, XrefRangeEnd = 334967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator TypeWrapper(sbyte obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TypeWrapper(intPtr);
			}
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x000EAEA4 File Offset: 0x000E90A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334967, XrefRangeEnd = 334968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator TypeWrapper(char obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TypeWrapper(intPtr);
			}
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x000EAEDC File Offset: 0x000E90DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334968, XrefRangeEnd = 334969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator TypeWrapper(short obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TypeWrapper(intPtr);
			}
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x000EAF14 File Offset: 0x000E9114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334969, XrefRangeEnd = 334970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator TypeWrapper(int obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TypeWrapper(intPtr);
			}
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x000EAF4C File Offset: 0x000E914C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334970, XrefRangeEnd = 334971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator TypeWrapper(long obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TypeWrapper(intPtr);
			}
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x000EAF84 File Offset: 0x000E9184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334971, XrefRangeEnd = 334972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator TypeWrapper(ushort obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TypeWrapper(intPtr);
			}
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x000EAFBC File Offset: 0x000E91BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334972, XrefRangeEnd = 334973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator TypeWrapper(uint obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TypeWrapper(intPtr);
			}
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x000EAFF4 File Offset: 0x000E91F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334973, XrefRangeEnd = 334974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator TypeWrapper(ulong obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TypeWrapper(intPtr);
			}
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x000EB02C File Offset: 0x000E922C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334974, XrefRangeEnd = 334975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator TypeWrapper(float obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TypeWrapper(intPtr);
			}
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x000EB064 File Offset: 0x000E9264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334975, XrefRangeEnd = 334976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator TypeWrapper(double obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TypeWrapper(intPtr);
			}
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x000EB09C File Offset: 0x000E929C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334976, XrefRangeEnd = 334977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator TypeWrapper(bool obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TypeWrapper(intPtr);
			}
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x000EB0D4 File Offset: 0x000E92D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334977, XrefRangeEnd = 334978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator TypeWrapper(string obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TypeWrapper(intPtr);
			}
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x00011355 File Offset: 0x0000F555
		public TypeWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x0001135E File Offset: 0x0000F55E
		public TypeWrapper()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr))
		{
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06002F31 RID: 12081 RVA: 0x000EB110 File Offset: 0x000E9310
		// (set) Token: 0x06002F32 RID: 12082 RVA: 0x00011370 File Offset: 0x0000F570
		public unsafe TypeWrapper.DataType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeWrapper.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeWrapper.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06002F33 RID: 12083 RVA: 0x000EB138 File Offset: 0x000E9338
		// (set) Token: 0x06002F34 RID: 12084 RVA: 0x0001138B File Offset: 0x0000F58B
		public unsafe RSlfnkpOdGXUGRIVtmWBVXkOPc CAptIFwjKcXIZCyiVWOUrBjngNpa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeWrapper.NativeFieldInfoPtr_CAptIFwjKcXIZCyiVWOUrBjngNpa);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeWrapper.NativeFieldInfoPtr_CAptIFwjKcXIZCyiVWOUrBjngNpa)) = value;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06002F35 RID: 12085 RVA: 0x000EB160 File Offset: 0x000E9360
		// (set) Token: 0x06002F36 RID: 12086 RVA: 0x000113A6 File Offset: 0x0000F5A6
		public unsafe string klMJYsQTpJWiuMmAwxgajgMtIPx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeWrapper.NativeFieldInfoPtr_klMJYsQTpJWiuMmAwxgajgMtIPx);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeWrapper.NativeFieldInfoPtr_klMJYsQTpJWiuMmAwxgajgMtIPx), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06002F37 RID: 12087 RVA: 0x000EB188 File Offset: 0x000E9388
		// (set) Token: 0x06002F38 RID: 12088 RVA: 0x000113C5 File Offset: 0x0000F5C5
		public unsafe Object TohavlHiixXcKvkPOcULdxnTJjh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeWrapper.NativeFieldInfoPtr_TohavlHiixXcKvkPOcULdxnTJjh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeWrapper.NativeFieldInfoPtr_TohavlHiixXcKvkPOcULdxnTJjh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027CF RID: 10191
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040027D0 RID: 10192
		private static readonly IntPtr NativeFieldInfoPtr_CAptIFwjKcXIZCyiVWOUrBjngNpa;

		// Token: 0x040027D1 RID: 10193
		private static readonly IntPtr NativeFieldInfoPtr_klMJYsQTpJWiuMmAwxgajgMtIPx;

		// Token: 0x040027D2 RID: 10194
		private static readonly IntPtr NativeFieldInfoPtr_TohavlHiixXcKvkPOcULdxnTJjh;

		// Token: 0x040027D3 RID: 10195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataType_0;

		// Token: 0x040027D4 RID: 10196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;

		// Token: 0x040027D5 RID: 10197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SByte_0;

		// Token: 0x040027D6 RID: 10198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_0;

		// Token: 0x040027D7 RID: 10199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_0;

		// Token: 0x040027D8 RID: 10200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_0;

		// Token: 0x040027D9 RID: 10201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040027DA RID: 10202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040027DB RID: 10203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x040027DC RID: 10204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x040027DD RID: 10205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040027DE RID: 10206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040027DF RID: 10207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040027E0 RID: 10208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040027E1 RID: 10209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x040027E2 RID: 10210
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040027E3 RID: 10211
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_TypeWrapper_0;

		// Token: 0x040027E4 RID: 10212
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SByte_TypeWrapper_0;

		// Token: 0x040027E5 RID: 10213
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Char_TypeWrapper_0;

		// Token: 0x040027E6 RID: 10214
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int16_TypeWrapper_0;

		// Token: 0x040027E7 RID: 10215
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_TypeWrapper_0;

		// Token: 0x040027E8 RID: 10216
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int64_TypeWrapper_0;

		// Token: 0x040027E9 RID: 10217
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_TypeWrapper_0;

		// Token: 0x040027EA RID: 10218
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_TypeWrapper_0;

		// Token: 0x040027EB RID: 10219
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_TypeWrapper_0;

		// Token: 0x040027EC RID: 10220
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Single_TypeWrapper_0;

		// Token: 0x040027ED RID: 10221
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Double_TypeWrapper_0;

		// Token: 0x040027EE RID: 10222
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_TypeWrapper_0;

		// Token: 0x040027EF RID: 10223
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_TypeWrapper_0;

		// Token: 0x040027F0 RID: 10224
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Byte_0;

		// Token: 0x040027F1 RID: 10225
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_SByte_0;

		// Token: 0x040027F2 RID: 10226
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Char_0;

		// Token: 0x040027F3 RID: 10227
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Int16_0;

		// Token: 0x040027F4 RID: 10228
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Int32_0;

		// Token: 0x040027F5 RID: 10229
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Int64_0;

		// Token: 0x040027F6 RID: 10230
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_UInt16_0;

		// Token: 0x040027F7 RID: 10231
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_UInt32_0;

		// Token: 0x040027F8 RID: 10232
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_UInt64_0;

		// Token: 0x040027F9 RID: 10233
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Single_0;

		// Token: 0x040027FA RID: 10234
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Double_0;

		// Token: 0x040027FB RID: 10235
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_Boolean_0;

		// Token: 0x040027FC RID: 10236
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TypeWrapper_String_0;

		// Token: 0x020003E8 RID: 1000
		[OriginalName("Rewired_Core.dll", "", "DataType")]
		public enum DataType
		{
			// Token: 0x04004304 RID: 17156
			Unknown,
			// Token: 0x04004305 RID: 17157
			Byte,
			// Token: 0x04004306 RID: 17158
			SByte,
			// Token: 0x04004307 RID: 17159
			Char,
			// Token: 0x04004308 RID: 17160
			Int16,
			// Token: 0x04004309 RID: 17161
			UInt16,
			// Token: 0x0400430A RID: 17162
			Int32,
			// Token: 0x0400430B RID: 17163
			UInt32,
			// Token: 0x0400430C RID: 17164
			Int64,
			// Token: 0x0400430D RID: 17165
			UInt64,
			// Token: 0x0400430E RID: 17166
			Single,
			// Token: 0x0400430F RID: 17167
			Double,
			// Token: 0x04004310 RID: 17168
			Boolean,
			// Token: 0x04004311 RID: 17169
			String,
			// Token: 0x04004312 RID: 17170
			Object
		}
	}
}
