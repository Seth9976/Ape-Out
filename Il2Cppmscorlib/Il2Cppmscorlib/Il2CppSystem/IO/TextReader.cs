using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000212 RID: 530
	[Serializable]
	public class TextReader : MarshalByRefObject
	{
		// Token: 0x0600229A RID: 8858 RVA: 0x000C05F8 File Offset: 0x000BE7F8
		// Note: this type is marked as 'beforefieldinit'.
		static TextReader()
		{
			Il2CppClassPointerStore<TextReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "TextReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextReader>.NativeClassPtr);
			TextReader.NativeFieldInfoPtr__ReadLineDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "_ReadLineDelegate");
			TextReader.NativeFieldInfoPtr__ReadDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "_ReadDelegate");
			TextReader.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "Null");
			TextReader.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100669141);
			TextReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100669142);
			TextReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100669143);
			TextReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100669144);
			TextReader.NativeMethodInfoPtr_Peek_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100669145);
			TextReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100669146);
			TextReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100669147);
			TextReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100669148);
			TextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100669149);
			TextReader.NativeMethodInfoPtr_Synchronized_Public_Static_TextReader_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100669150);
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x000C072C File Offset: 0x000BE92C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x000C0768 File Offset: 0x000BE968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191770, XrefRangeEnd = 191774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x000C07A4 File Offset: 0x000BE9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191774, XrefRangeEnd = 191778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x000C07D8 File Offset: 0x000BE9D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x000C0824 File Offset: 0x000BEA24
		[CallerCount(0)]
		public unsafe virtual int Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Peek_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x000C086C File Offset: 0x000BEA6C
		[CallerCount(0)]
		public unsafe virtual int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x000C08B4 File Offset: 0x000BEAB4
		[CallerCount(0)]
		public unsafe virtual int Read([In] [Out] Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x000C093C File Offset: 0x000BEB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191778, XrefRangeEnd = 191791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x000C0980 File Offset: 0x000BEB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191791, XrefRangeEnd = 191799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x000C09C4 File Offset: 0x000BEBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191799, XrefRangeEnd = 191805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextReader Synchronized(TextReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NativeMethodInfoPtr_Synchronized_Public_Static_TextReader_TextReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr3) : null;
			}
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x0000B95C File Offset: 0x00009B5C
		public TextReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060022A6 RID: 8870 RVA: 0x000C0A08 File Offset: 0x000BEC08
		// (set) Token: 0x060022A7 RID: 8871 RVA: 0x0000B965 File Offset: 0x00009B65
		public unsafe static Func<Object, string> _ReadLineDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextReader.NativeFieldInfoPtr__ReadLineDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextReader.NativeFieldInfoPtr__ReadLineDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x000C0A30 File Offset: 0x000BEC30
		// (set) Token: 0x060022A9 RID: 8873 RVA: 0x0000B977 File Offset: 0x00009B77
		public unsafe static Func<Object, int> _ReadDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextReader.NativeFieldInfoPtr__ReadDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextReader.NativeFieldInfoPtr__ReadDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x000C0A58 File Offset: 0x000BEC58
		// (set) Token: 0x060022AB RID: 8875 RVA: 0x0000B989 File Offset: 0x00009B89
		public unsafe static TextReader Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextReader.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextReader.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EFB RID: 7931
		private static readonly IntPtr NativeFieldInfoPtr__ReadLineDelegate;

		// Token: 0x04001EFC RID: 7932
		private static readonly IntPtr NativeFieldInfoPtr__ReadDelegate;

		// Token: 0x04001EFD RID: 7933
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001EFE RID: 7934
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001EFF RID: 7935
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04001F00 RID: 7936
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001F01 RID: 7937
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001F02 RID: 7938
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_New_Int32_0;

		// Token: 0x04001F03 RID: 7939
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0;

		// Token: 0x04001F04 RID: 7940
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001F05 RID: 7941
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_New_String_0;

		// Token: 0x04001F06 RID: 7942
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_New_String_0;

		// Token: 0x04001F07 RID: 7943
		private static readonly IntPtr NativeMethodInfoPtr_Synchronized_Public_Static_TextReader_TextReader_0;

		// Token: 0x020005D8 RID: 1496
		[Serializable]
		public sealed class NullTextReader : TextReader
		{
			// Token: 0x06005373 RID: 21363 RVA: 0x00178060 File Offset: 0x00176260
			// Note: this type is marked as 'beforefieldinit'.
			static NullTextReader()
			{
				Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "NullTextReader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr);
				TextReader.NullTextReader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr, 100669152);
				TextReader.NullTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr, 100669153);
				TextReader.NullTextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr, 100669154);
			}

			// Token: 0x06005374 RID: 21364 RVA: 0x001780C8 File Offset: 0x001762C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191742, XrefRangeEnd = 191745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NullTextReader()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NullTextReader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005375 RID: 21365 RVA: 0x00178104 File Offset: 0x00176304
			[CallerCount(0)]
			public unsafe override int Read(Il2CppStructArray<char> buffer, int index, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NullTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005376 RID: 21366 RVA: 0x00178170 File Offset: 0x00176370
			[CallerCount(0)]
			public unsafe override string ReadLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NullTextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06005377 RID: 21367 RVA: 0x0001F76B File Offset: 0x0001D96B
			public NullTextReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004389 RID: 17289
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400438A RID: 17290
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x0400438B RID: 17291
			private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;
		}

		// Token: 0x020005D9 RID: 1497
		[Serializable]
		public sealed class SyncTextReader : TextReader
		{
			// Token: 0x06005378 RID: 21368 RVA: 0x001781A8 File Offset: 0x001763A8
			// Note: this type is marked as 'beforefieldinit'.
			static SyncTextReader()
			{
				Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "SyncTextReader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr);
				TextReader.SyncTextReader.NativeFieldInfoPtr__in = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, "_in");
				TextReader.SyncTextReader.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100669155);
				TextReader.SyncTextReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100669156);
				TextReader.SyncTextReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100669157);
				TextReader.SyncTextReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100669158);
				TextReader.SyncTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100669159);
				TextReader.SyncTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100669160);
				TextReader.SyncTextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100669161);
				TextReader.SyncTextReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100669162);
			}

			// Token: 0x06005379 RID: 21369 RVA: 0x00178288 File Offset: 0x00176488
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191745, XrefRangeEnd = 191748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SyncTextReader(TextReader t)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600537A RID: 21370 RVA: 0x001782D4 File Offset: 0x001764D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191748, XrefRangeEnd = 191749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Close()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600537B RID: 21371 RVA: 0x00178308 File Offset: 0x00176508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191749, XrefRangeEnd = 191752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600537C RID: 21372 RVA: 0x00178348 File Offset: 0x00176548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Peek()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600537D RID: 21373 RVA: 0x00178384 File Offset: 0x00176584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191752, XrefRangeEnd = 191753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Read()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600537E RID: 21374 RVA: 0x001783C0 File Offset: 0x001765C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191753, XrefRangeEnd = 191754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Read([In] [Out] Il2CppStructArray<char> buffer, int index, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = 0;
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600537F RID: 21375 RVA: 0x0017843C File Offset: 0x0017663C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191754, XrefRangeEnd = 191755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ReadLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06005380 RID: 21376 RVA: 0x00178474 File Offset: 0x00176674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191755, XrefRangeEnd = 191760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ReadToEnd()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06005381 RID: 21377 RVA: 0x0001F774 File Offset: 0x0001D974
			public SyncTextReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001572 RID: 5490
			// (get) Token: 0x06005382 RID: 21378 RVA: 0x001784AC File Offset: 0x001766AC
			// (set) Token: 0x06005383 RID: 21379 RVA: 0x0001F77D File Offset: 0x0001D97D
			public unsafe TextReader _in
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReader.SyncTextReader.NativeFieldInfoPtr__in);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReader.SyncTextReader.NativeFieldInfoPtr__in), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400438C RID: 17292
			private static readonly IntPtr NativeFieldInfoPtr__in;

			// Token: 0x0400438D RID: 17293
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TextReader_0;

			// Token: 0x0400438E RID: 17294
			private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

			// Token: 0x0400438F RID: 17295
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

			// Token: 0x04004390 RID: 17296
			private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0;

			// Token: 0x04004391 RID: 17297
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_0;

			// Token: 0x04004392 RID: 17298
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04004393 RID: 17299
			private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;

			// Token: 0x04004394 RID: 17300
			private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0;
		}

		// Token: 0x020005DA RID: 1498
		[ObfuscatedName("System.IO.TextReader+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005384 RID: 21380 RVA: 0x001784DC File Offset: 0x001766DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr);
				TextReader.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr, "<>9");
				TextReader.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr, 100669164);
				TextReader.__c.NativeMethodInfoPtr___cctor_b__22_0_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr, 100669165);
				TextReader.__c.NativeMethodInfoPtr___cctor_b__22_1_Internal_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr, 100669166);
			}

			// Token: 0x06005385 RID: 21381 RVA: 0x00178558 File Offset: 0x00176758
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005386 RID: 21382 RVA: 0x00178594 File Offset: 0x00176794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191760, XrefRangeEnd = 191764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string __cctor_b__22_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.__c.NativeMethodInfoPtr___cctor_b__22_0_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005387 RID: 21383 RVA: 0x001785DC File Offset: 0x001767DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191764, XrefRangeEnd = 191770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int __cctor_b__22_1(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.__c.NativeMethodInfoPtr___cctor_b__22_1_Internal_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005388 RID: 21384 RVA: 0x0001F79C File Offset: 0x0001D99C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001573 RID: 5491
			// (get) Token: 0x06005389 RID: 21385 RVA: 0x0017862C File Offset: 0x0017682C
			// (set) Token: 0x0600538A RID: 21386 RVA: 0x0001F7A5 File Offset: 0x0001D9A5
			public unsafe static TextReader.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextReader.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextReader.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004395 RID: 17301
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004396 RID: 17302
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004397 RID: 17303
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__22_0_Internal_String_Object_0;

			// Token: 0x04004398 RID: 17304
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__22_1_Internal_Int32_Object_0;
		}
	}
}
