using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x02000213 RID: 531
	[Serializable]
	public class TextWriter : MarshalByRefObject
	{
		// Token: 0x060022AC RID: 8876 RVA: 0x000C0A80 File Offset: 0x000BEC80
		// Note: this type is marked as 'beforefieldinit'.
		static TextWriter()
		{
			Il2CppClassPointerStore<TextWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "TextWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextWriter>.NativeClassPtr);
			TextWriter.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "Null");
			TextWriter.NativeFieldInfoPtr__WriteCharDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "_WriteCharDelegate");
			TextWriter.NativeFieldInfoPtr__WriteStringDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "_WriteStringDelegate");
			TextWriter.NativeFieldInfoPtr__WriteCharArrayRangeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "_WriteCharArrayRangeDelegate");
			TextWriter.NativeFieldInfoPtr__WriteLineCharDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "_WriteLineCharDelegate");
			TextWriter.NativeFieldInfoPtr__WriteLineStringDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "_WriteLineStringDelegate");
			TextWriter.NativeFieldInfoPtr__WriteLineCharArrayRangeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "_WriteLineCharArrayRangeDelegate");
			TextWriter.NativeFieldInfoPtr__FlushDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "_FlushDelegate");
			TextWriter.NativeFieldInfoPtr_CoreNewLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "CoreNewLine");
			TextWriter.NativeFieldInfoPtr_InternalFormatProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "InternalFormatProvider");
			TextWriter.NativeMethodInfoPtr_get_InitialNewLine_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669167);
			TextWriter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669168);
			TextWriter.NativeMethodInfoPtr__ctor_Protected_Void_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669169);
			TextWriter.NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_New_get_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669170);
			TextWriter.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669171);
			TextWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669172);
			TextWriter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669173);
			TextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669174);
			TextWriter.NativeMethodInfoPtr_get_Encoding_Public_Abstract_Virtual_New_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669175);
			TextWriter.NativeMethodInfoPtr_Synchronized_Public_Static_TextWriter_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669176);
			TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669177);
			TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669178);
			TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669179);
			TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669180);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669181);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669182);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669183);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669184);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669185);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669186);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669187);
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x000C0D1C File Offset: 0x000BEF1C
		public unsafe static string InitialNewLine
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191880, XrefRangeEnd = 191881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NativeMethodInfoPtr_get_InitialNewLine_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x000C0D48 File Offset: 0x000BEF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191881, XrefRangeEnd = 191886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x000C0D84 File Offset: 0x000BEF84
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 191891, RefRangeEnd = 191900, XrefRangeStart = 191886, XrefRangeEnd = 191891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextWriter(IFormatProvider formatProvider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NativeMethodInfoPtr__ctor_Protected_Void_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x000C0DD0 File Offset: 0x000BEFD0
		public unsafe virtual IFormatProvider FormatProvider
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191900, XrefRangeEnd = 191902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_New_get_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr3) : null;
			}
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x000C0E1C File Offset: 0x000BF01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191902, XrefRangeEnd = 191906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x000C0E58 File Offset: 0x000BF058
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x000C0EA4 File Offset: 0x000BF0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191906, XrefRangeEnd = 191910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x000C0ED8 File Offset: 0x000BF0D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x000C0F14 File Offset: 0x000BF114
		public unsafe virtual Encoding Encoding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_get_Encoding_Public_Abstract_Virtual_New_get_Encoding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x000C0F60 File Offset: 0x000BF160
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191917, RefRangeEnd = 191919, XrefRangeStart = 191910, XrefRangeEnd = 191917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextWriter Synchronized(TextWriter writer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NativeMethodInfoPtr_Synchronized_Public_Static_TextWriter_TextWriter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr3) : null;
			}
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x000C0FA4 File Offset: 0x000BF1A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x000C0FF0 File Offset: 0x000BF1F0
		[CallerCount(0)]
		public unsafe virtual void Write(Il2CppStructArray<char> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x000C1040 File Offset: 0x000BF240
		[CallerCount(0)]
		public unsafe virtual void Write(Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x000C10AC File Offset: 0x000BF2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191919, XrefRangeEnd = 191920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x000C10FC File Offset: 0x000BF2FC
		[CallerCount(0)]
		public unsafe virtual void WriteLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x000C1138 File Offset: 0x000BF338
		[CallerCount(0)]
		public unsafe virtual void WriteLine(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x000C1184 File Offset: 0x000BF384
		[CallerCount(0)]
		public unsafe virtual void WriteLine(Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x000C11F0 File Offset: 0x000BF3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191920, XrefRangeEnd = 191931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteLine(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x000C1240 File Offset: 0x000BF440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191931, XrefRangeEnd = 191936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteLine(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x000C1290 File Offset: 0x000BF490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191936, XrefRangeEnd = 191937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteLine(string format, Object arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x000C12F0 File Offset: 0x000BF4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191937, XrefRangeEnd = 192002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteLine(string format, Object arg0, Object arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x0000B99B File Offset: 0x00009B9B
		public TextWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x000C1364 File Offset: 0x000BF564
		// (set) Token: 0x060022C4 RID: 8900 RVA: 0x0000B9A4 File Offset: 0x00009BA4
		public unsafe static TextWriter Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x000C138C File Offset: 0x000BF58C
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x0000B9B6 File Offset: 0x00009BB6
		public unsafe static Action<Object> _WriteCharDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr__WriteCharDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr__WriteCharDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x000C13B4 File Offset: 0x000BF5B4
		// (set) Token: 0x060022C8 RID: 8904 RVA: 0x0000B9C8 File Offset: 0x00009BC8
		public unsafe static Action<Object> _WriteStringDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr__WriteStringDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr__WriteStringDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x000C13DC File Offset: 0x000BF5DC
		// (set) Token: 0x060022CA RID: 8906 RVA: 0x0000B9DA File Offset: 0x00009BDA
		public unsafe static Action<Object> _WriteCharArrayRangeDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr__WriteCharArrayRangeDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr__WriteCharArrayRangeDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x000C1404 File Offset: 0x000BF604
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x0000B9EC File Offset: 0x00009BEC
		public unsafe static Action<Object> _WriteLineCharDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr__WriteLineCharDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr__WriteLineCharDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x000C142C File Offset: 0x000BF62C
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x0000B9FE File Offset: 0x00009BFE
		public unsafe static Action<Object> _WriteLineStringDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr__WriteLineStringDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr__WriteLineStringDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x000C1454 File Offset: 0x000BF654
		// (set) Token: 0x060022D0 RID: 8912 RVA: 0x0000BA10 File Offset: 0x00009C10
		public unsafe static Action<Object> _WriteLineCharArrayRangeDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr__WriteLineCharArrayRangeDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr__WriteLineCharArrayRangeDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x000C147C File Offset: 0x000BF67C
		// (set) Token: 0x060022D2 RID: 8914 RVA: 0x0000BA22 File Offset: 0x00009C22
		public unsafe static Action<Object> _FlushDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr__FlushDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr__FlushDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x000C14A4 File Offset: 0x000BF6A4
		// (set) Token: 0x060022D4 RID: 8916 RVA: 0x0000BA34 File Offset: 0x00009C34
		public unsafe Il2CppStructArray<char> CoreNewLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.NativeFieldInfoPtr_CoreNewLine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.NativeFieldInfoPtr_CoreNewLine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x000C14D4 File Offset: 0x000BF6D4
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x0000BA53 File Offset: 0x00009C53
		public unsafe IFormatProvider InternalFormatProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.NativeFieldInfoPtr_InternalFormatProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.NativeFieldInfoPtr_InternalFormatProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F08 RID: 7944
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001F09 RID: 7945
		private static readonly IntPtr NativeFieldInfoPtr__WriteCharDelegate;

		// Token: 0x04001F0A RID: 7946
		private static readonly IntPtr NativeFieldInfoPtr__WriteStringDelegate;

		// Token: 0x04001F0B RID: 7947
		private static readonly IntPtr NativeFieldInfoPtr__WriteCharArrayRangeDelegate;

		// Token: 0x04001F0C RID: 7948
		private static readonly IntPtr NativeFieldInfoPtr__WriteLineCharDelegate;

		// Token: 0x04001F0D RID: 7949
		private static readonly IntPtr NativeFieldInfoPtr__WriteLineStringDelegate;

		// Token: 0x04001F0E RID: 7950
		private static readonly IntPtr NativeFieldInfoPtr__WriteLineCharArrayRangeDelegate;

		// Token: 0x04001F0F RID: 7951
		private static readonly IntPtr NativeFieldInfoPtr__FlushDelegate;

		// Token: 0x04001F10 RID: 7952
		private static readonly IntPtr NativeFieldInfoPtr_CoreNewLine;

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeFieldInfoPtr_InternalFormatProvider;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialNewLine_Private_Static_get_String_0;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IFormatProvider_0;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_New_get_IFormatProvider_0;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001F18 RID: 7960
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001F19 RID: 7961
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0;

		// Token: 0x04001F1A RID: 7962
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_Abstract_Virtual_New_get_Encoding_0;

		// Token: 0x04001F1B RID: 7963
		private static readonly IntPtr NativeMethodInfoPtr_Synchronized_Public_Static_TextWriter_TextWriter_0;

		// Token: 0x04001F1C RID: 7964
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Char_0;

		// Token: 0x04001F1D RID: 7965
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04001F1E RID: 7966
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001F1F RID: 7967
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_0;

		// Token: 0x04001F20 RID: 7968
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_0;

		// Token: 0x04001F21 RID: 7969
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_Char_0;

		// Token: 0x04001F22 RID: 7970
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001F23 RID: 7971
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_0;

		// Token: 0x04001F24 RID: 7972
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_Object_0;

		// Token: 0x04001F25 RID: 7973
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_Object_0;

		// Token: 0x04001F26 RID: 7974
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_Object_Object_0;

		// Token: 0x020005DB RID: 1499
		[Serializable]
		public sealed class NullTextWriter : TextWriter
		{
			// Token: 0x0600538B RID: 21387 RVA: 0x00178654 File Offset: 0x00176854
			// Note: this type is marked as 'beforefieldinit'.
			static NullTextWriter()
			{
				Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "NullTextWriter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr);
				TextWriter.NullTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100669189);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100669190);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100669191);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100669192);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100669193);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100669194);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100669195);
			}

			// Token: 0x0600538C RID: 21388 RVA: 0x0017870C File Offset: 0x0017690C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191805, XrefRangeEnd = 191817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NullTextWriter()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001574 RID: 5492
			// (get) Token: 0x0600538D RID: 21389 RVA: 0x00178748 File Offset: 0x00176948
			public unsafe override Encoding Encoding
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191817, XrefRangeEnd = 191818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
				}
			}

			// Token: 0x0600538E RID: 21390 RVA: 0x00178788 File Offset: 0x00176988
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(Il2CppStructArray<char> buffer, int index, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600538F RID: 21391 RVA: 0x001787E8 File Offset: 0x001769E8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005390 RID: 21392 RVA: 0x0017882C File Offset: 0x00176A2C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005391 RID: 21393 RVA: 0x00178860 File Offset: 0x00176A60
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005392 RID: 21394 RVA: 0x001788A4 File Offset: 0x00176AA4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005393 RID: 21395 RVA: 0x0001F7B7 File Offset: 0x0001D9B7
			public NullTextWriter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004399 RID: 17305
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x0400439A RID: 17306
			private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0;

			// Token: 0x0400439B RID: 17307
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x0400439C RID: 17308
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;

			// Token: 0x0400439D RID: 17309
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0;

			// Token: 0x0400439E RID: 17310
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0;

			// Token: 0x0400439F RID: 17311
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Object_0;
		}

		// Token: 0x020005DC RID: 1500
		[Serializable]
		public sealed class SyncTextWriter : TextWriter
		{
			// Token: 0x06005394 RID: 21396 RVA: 0x001788E8 File Offset: 0x00176AE8
			// Note: this type is marked as 'beforefieldinit'.
			static SyncTextWriter()
			{
				Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "SyncTextWriter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr);
				TextWriter.SyncTextWriter.NativeFieldInfoPtr__out = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, "_out");
				TextWriter.SyncTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669196);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669197);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_get_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669198);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669199);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669200);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669201);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669202);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669203);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669204);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669205);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669206);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669207);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669208);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669209);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669210);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669211);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669212);
			}

			// Token: 0x06005395 RID: 21397 RVA: 0x00178A7C File Offset: 0x00176C7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191818, XrefRangeEnd = 191822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SyncTextWriter(TextWriter t)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_TextWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001576 RID: 5494
			// (get) Token: 0x06005396 RID: 21398 RVA: 0x00178AC8 File Offset: 0x00176CC8
			public unsafe override Encoding Encoding
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191822, XrefRangeEnd = 191823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
				}
			}

			// Token: 0x17001577 RID: 5495
			// (get) Token: 0x06005397 RID: 21399 RVA: 0x00178B08 File Offset: 0x00176D08
			public unsafe override IFormatProvider FormatProvider
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191823, XrefRangeEnd = 191824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_get_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr3) : null;
				}
			}

			// Token: 0x06005398 RID: 21400 RVA: 0x00178B48 File Offset: 0x00176D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191824, XrefRangeEnd = 191825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Close()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005399 RID: 21401 RVA: 0x00178B7C File Offset: 0x00176D7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191825, XrefRangeEnd = 191828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600539A RID: 21402 RVA: 0x00178BBC File Offset: 0x00176DBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191828, XrefRangeEnd = 191829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Flush()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600539B RID: 21403 RVA: 0x00178BF0 File Offset: 0x00176DF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191829, XrefRangeEnd = 191830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(char value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600539C RID: 21404 RVA: 0x00178C30 File Offset: 0x00176E30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191830, XrefRangeEnd = 191831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(Il2CppStructArray<char> buffer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600539D RID: 21405 RVA: 0x00178C74 File Offset: 0x00176E74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191831, XrefRangeEnd = 191832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(Il2CppStructArray<char> buffer, int index, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600539E RID: 21406 RVA: 0x00178CD4 File Offset: 0x00176ED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191832, XrefRangeEnd = 191833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600539F RID: 21407 RVA: 0x00178D18 File Offset: 0x00176F18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191833, XrefRangeEnd = 191834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053A0 RID: 21408 RVA: 0x00178D4C File Offset: 0x00176F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191834, XrefRangeEnd = 191835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(char value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053A1 RID: 21409 RVA: 0x00178D8C File Offset: 0x00176F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191835, XrefRangeEnd = 191836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(Il2CppStructArray<char> buffer, int index, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053A2 RID: 21410 RVA: 0x00178DEC File Offset: 0x00176FEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191836, XrefRangeEnd = 191837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053A3 RID: 21411 RVA: 0x00178E30 File Offset: 0x00177030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191837, XrefRangeEnd = 191838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053A4 RID: 21412 RVA: 0x00178E74 File Offset: 0x00177074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191838, XrefRangeEnd = 191839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(string format, Object arg0)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053A5 RID: 21413 RVA: 0x00178EC8 File Offset: 0x001770C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191839, XrefRangeEnd = 191840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(string format, Object arg0, Object arg1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053A6 RID: 21414 RVA: 0x0001F7C0 File Offset: 0x0001D9C0
			public SyncTextWriter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001575 RID: 5493
			// (get) Token: 0x060053A7 RID: 21415 RVA: 0x00178F30 File Offset: 0x00177130
			// (set) Token: 0x060053A8 RID: 21416 RVA: 0x0001F7C9 File Offset: 0x0001D9C9
			public unsafe TextWriter _out
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.SyncTextWriter.NativeFieldInfoPtr__out);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.SyncTextWriter.NativeFieldInfoPtr__out), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043A0 RID: 17312
			private static readonly IntPtr NativeFieldInfoPtr__out;

			// Token: 0x040043A1 RID: 17313
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TextWriter_0;

			// Token: 0x040043A2 RID: 17314
			private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0;

			// Token: 0x040043A3 RID: 17315
			private static readonly IntPtr NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_get_IFormatProvider_0;

			// Token: 0x040043A4 RID: 17316
			private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

			// Token: 0x040043A5 RID: 17317
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

			// Token: 0x040043A6 RID: 17318
			private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

			// Token: 0x040043A7 RID: 17319
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0;

			// Token: 0x040043A8 RID: 17320
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0;

			// Token: 0x040043A9 RID: 17321
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x040043AA RID: 17322
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;

			// Token: 0x040043AB RID: 17323
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0;

			// Token: 0x040043AC RID: 17324
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Char_0;

			// Token: 0x040043AD RID: 17325
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x040043AE RID: 17326
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0;

			// Token: 0x040043AF RID: 17327
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Object_0;

			// Token: 0x040043B0 RID: 17328
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_Object_0;

			// Token: 0x040043B1 RID: 17329
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_Object_Object_0;
		}

		// Token: 0x020005DD RID: 1501
		[ObfuscatedName("System.IO.TextWriter+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060053A9 RID: 21417 RVA: 0x00178F60 File Offset: 0x00177160
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr);
				TextWriter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, "<>9");
				TextWriter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669214);
				TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669215);
				TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669216);
				TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_2_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669217);
				TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_3_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669218);
				TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_4_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669219);
				TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_5_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669220);
				TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_6_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669221);
			}

			// Token: 0x060053AA RID: 21418 RVA: 0x00179040 File Offset: 0x00177240
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053AB RID: 21419 RVA: 0x0017907C File Offset: 0x0017727C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191840, XrefRangeEnd = 191846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__73_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053AC RID: 21420 RVA: 0x001790C0 File Offset: 0x001772C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191846, XrefRangeEnd = 191852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__73_1(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053AD RID: 21421 RVA: 0x00179104 File Offset: 0x00177304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191852, XrefRangeEnd = 191858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__73_2(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_2_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053AE RID: 21422 RVA: 0x00179148 File Offset: 0x00177348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191858, XrefRangeEnd = 191864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__73_3(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_3_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053AF RID: 21423 RVA: 0x0017918C File Offset: 0x0017738C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191864, XrefRangeEnd = 191870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__73_4(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_4_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053B0 RID: 21424 RVA: 0x001791D0 File Offset: 0x001773D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191870, XrefRangeEnd = 191876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__73_5(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_5_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053B1 RID: 21425 RVA: 0x00179214 File Offset: 0x00177414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191876, XrefRangeEnd = 191880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__73_6(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_6_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053B2 RID: 21426 RVA: 0x0001F7E8 File Offset: 0x0001D9E8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001578 RID: 5496
			// (get) Token: 0x060053B3 RID: 21427 RVA: 0x00179258 File Offset: 0x00177458
			// (set) Token: 0x060053B4 RID: 21428 RVA: 0x0001F7F1 File Offset: 0x0001D9F1
			public unsafe static TextWriter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextWriter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextWriter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043B2 RID: 17330
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040043B3 RID: 17331
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040043B4 RID: 17332
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__73_0_Internal_Void_Object_0;

			// Token: 0x040043B5 RID: 17333
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__73_1_Internal_Void_Object_0;

			// Token: 0x040043B6 RID: 17334
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__73_2_Internal_Void_Object_0;

			// Token: 0x040043B7 RID: 17335
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__73_3_Internal_Void_Object_0;

			// Token: 0x040043B8 RID: 17336
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__73_4_Internal_Void_Object_0;

			// Token: 0x040043B9 RID: 17337
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__73_5_Internal_Void_Object_0;

			// Token: 0x040043BA RID: 17338
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__73_6_Internal_Void_Object_0;
		}
	}
}
