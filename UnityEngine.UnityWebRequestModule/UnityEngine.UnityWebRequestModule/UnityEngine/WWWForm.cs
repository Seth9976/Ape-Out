using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public class WWWForm : Object
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002930 File Offset: 0x00000B30
		// Note: this type is marked as 'beforefieldinit'.
		static WWWForm()
		{
			Il2CppClassPointerStore<WWWForm>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine", "WWWForm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WWWForm>.NativeClassPtr);
			WWWForm.NativeFieldInfoPtr_formData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, "formData");
			WWWForm.NativeFieldInfoPtr_fieldNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, "fieldNames");
			WWWForm.NativeFieldInfoPtr_fileNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, "fileNames");
			WWWForm.NativeFieldInfoPtr_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, "types");
			WWWForm.NativeFieldInfoPtr_boundary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, "boundary");
			WWWForm.NativeFieldInfoPtr_containsFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, "containsFiles");
			WWWForm.NativeMethodInfoPtr_get_DefaultEncoding_Internal_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, 100663302);
			WWWForm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, 100663303);
			WWWForm.NativeMethodInfoPtr_AddField_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, 100663304);
			WWWForm.NativeMethodInfoPtr_AddField_Public_Void_String_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, 100663305);
			WWWForm.NativeMethodInfoPtr_get_headers_Public_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, 100663306);
			WWWForm.NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWForm>.NativeClassPtr, 100663307);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002A50 File Offset: 0x00000C50
		public unsafe static Encoding DefaultEncoding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534295, XrefRangeEnd = 534296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWForm.NativeMethodInfoPtr_get_DefaultEncoding_Internal_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002A84 File Offset: 0x00000C84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 534321, RefRangeEnd = 534323, XrefRangeStart = 534296, XrefRangeEnd = 534321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WWWForm()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WWWForm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWForm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 534340, RefRangeEnd = 534346, XrefRangeStart = 534323, XrefRangeEnd = 534340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddField(string fieldName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWForm.NativeMethodInfoPtr_AddField_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002B14 File Offset: 0x00000D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534346, XrefRangeEnd = 534362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddField(string fieldName, string value, Encoding e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWForm.NativeMethodInfoPtr_AddField_Public_Void_String_String_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002B7C File Offset: 0x00000D7C
		public unsafe Dictionary<string, string> headers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534362, XrefRangeEnd = 534381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWForm.NativeMethodInfoPtr_get_headers_Public_get_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002BBC File Offset: 0x00000DBC
		public unsafe Il2CppStructArray<byte> data
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 534510, RefRangeEnd = 534511, XrefRangeStart = 534381, XrefRangeEnd = 534510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWForm.NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000206B File Offset: 0x0000026B
		public WWWForm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002BFC File Offset: 0x00000DFC
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002074 File Offset: 0x00000274
		public unsafe List<Il2CppStructArray<byte>> formData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWForm.NativeFieldInfoPtr_formData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppStructArray<byte>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWForm.NativeFieldInfoPtr_formData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002C2C File Offset: 0x00000E2C
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002093 File Offset: 0x00000293
		public unsafe List<string> fieldNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWForm.NativeFieldInfoPtr_fieldNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWForm.NativeFieldInfoPtr_fieldNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002C5C File Offset: 0x00000E5C
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000020B2 File Offset: 0x000002B2
		public unsafe List<string> fileNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWForm.NativeFieldInfoPtr_fileNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWForm.NativeFieldInfoPtr_fileNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002C8C File Offset: 0x00000E8C
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000020D1 File Offset: 0x000002D1
		public unsafe List<string> types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWForm.NativeFieldInfoPtr_types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWForm.NativeFieldInfoPtr_types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002CBC File Offset: 0x00000EBC
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000020F0 File Offset: 0x000002F0
		public unsafe Il2CppStructArray<byte> boundary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWForm.NativeFieldInfoPtr_boundary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWForm.NativeFieldInfoPtr_boundary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002CEC File Offset: 0x00000EEC
		// (set) Token: 0x0600001C RID: 28 RVA: 0x0000210F File Offset: 0x0000030F
		public unsafe bool containsFiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWForm.NativeFieldInfoPtr_containsFiles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWForm.NativeFieldInfoPtr_containsFiles)) = value;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000212A File Offset: 0x0000032A
		public void AddField(string fieldName, int i)
		{
			this.AddField(fieldName, i.ToString());
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000213C File Offset: 0x0000033C
		public void AddBinaryData(string fieldName, Il2CppStructArray<byte> contents)
		{
			this.AddBinaryData(fieldName, contents, null, null);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000214A File Offset: 0x0000034A
		public void AddBinaryData(string fieldName, Il2CppStructArray<byte> contents, string fileName)
		{
			this.AddBinaryData(fieldName, contents, fileName, null);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002158 File Offset: 0x00000358
		public void AddBinaryData(string fieldName, Il2CppStructArray<byte> contents, string fileName, string mimeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_formData;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_fieldNames;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_fileNames;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_types;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_boundary;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_containsFiles;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultEncoding_Internal_Static_get_Encoding_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_AddField_Public_Void_String_String_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_AddField_Public_Void_String_String_Encoding_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_headers_Public_get_Dictionary_2_String_String_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Byte_0;
	}
}
