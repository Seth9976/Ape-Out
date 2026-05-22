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
	// Token: 0x020000E6 RID: 230
	public class TextAsset : Object
	{
		// Token: 0x0600137E RID: 4990 RVA: 0x0004F1AC File Offset: 0x0004D3AC
		// Note: this type is marked as 'beforefieldinit'.
		static TextAsset()
		{
			Il2CppClassPointerStore<TextAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TextAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextAsset>.NativeClassPtr);
			TextAsset.NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100664989);
			TextAsset.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100664990);
			TextAsset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100664991);
			TextAsset.NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100664992);
			TextAsset.GetPreviewBytesDelegateField = IL2CPP.ResolveICall<TextAsset.GetPreviewBytesDelegate>("UnityEngine.TextAsset::GetPreviewBytes");
			TextAsset.Internal_CreateInstanceDelegateField = IL2CPP.ResolveICall<TextAsset.Internal_CreateInstanceDelegate>("UnityEngine.TextAsset::Internal_CreateInstance");
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x0004F24C File Offset: 0x0004D44C
		public unsafe Il2CppStructArray<byte> bytes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 496823, RefRangeEnd = 496824, XrefRangeStart = 496819, XrefRangeEnd = 496823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x0004F28C File Offset: 0x0004D48C
		public unsafe string text
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 496829, RefRangeEnd = 496832, XrefRangeStart = 496824, XrefRangeEnd = 496829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0004F2C4 File Offset: 0x0004D4C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 496829, RefRangeEnd = 496832, XrefRangeStart = 496829, XrefRangeEnd = 496832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextAsset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x0004F308 File Offset: 0x0004D508
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 496849, RefRangeEnd = 496852, XrefRangeStart = 496832, XrefRangeEnd = 496849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DecodeString(Il2CppStructArray<byte> bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0000AED9 File Offset: 0x000090D9
		public TextAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0004F344 File Offset: 0x0004D544
		public Il2CppStructArray<byte> GetPreviewBytes(int maxByteCount)
		{
			IntPtr intPtr = TextAsset.GetPreviewBytesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), maxByteCount);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0000AEE2 File Offset: 0x000090E2
		public static void Internal_CreateInstance(TextAsset self, string text)
		{
			TextAsset.Internal_CreateInstanceDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.ManagedStringToIl2Cpp(text));
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0004F374 File Offset: 0x0004D574
		public string GetPreview(int maxChars)
		{
			return TextAsset.DecodeString(this.GetPreviewBytes(maxChars * 4));
		}

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000F85 RID: 3973
		private static readonly TextAsset.GetPreviewBytesDelegate GetPreviewBytesDelegateField;

		// Token: 0x04000F86 RID: 3974
		private static readonly TextAsset.Internal_CreateInstanceDelegate Internal_CreateInstanceDelegateField;

		// Token: 0x020007BA RID: 1978
		public static class EncodingUtility : Object
		{
			// Token: 0x06002D6C RID: 11628 RVA: 0x000137B1 File Offset: 0x000119B1
			// Note: this type is marked as 'beforefieldinit'.
			static EncodingUtility()
			{
				Il2CppClassPointerStore<TextAsset.EncodingUtility>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, "EncodingUtility");
				TextAsset.EncodingUtility.NativeFieldInfoPtr_encodingLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAsset.EncodingUtility>.NativeClassPtr, "encodingLookup");
				TextAsset.EncodingUtility.NativeFieldInfoPtr_targetEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAsset.EncodingUtility>.NativeClassPtr, "targetEncoding");
			}

			// Token: 0x06002D6D RID: 11629 RVA: 0x000137EF File Offset: 0x000119EF
			public EncodingUtility(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000728 RID: 1832
			// (get) Token: 0x06002D6E RID: 11630 RVA: 0x0007C1A8 File Offset: 0x0007A3A8
			// (set) Token: 0x06002D6F RID: 11631 RVA: 0x000137F8 File Offset: 0x000119F8
			public unsafe static Il2CppReferenceArray<KeyValuePair<Il2CppStructArray<byte>, Encoding>> encodingLookup
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_encodingLookup, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<Il2CppStructArray<byte>, Encoding>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_encodingLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000729 RID: 1833
			// (get) Token: 0x06002D70 RID: 11632 RVA: 0x0007C1D0 File Offset: 0x0007A3D0
			// (set) Token: 0x06002D71 RID: 11633 RVA: 0x0001380A File Offset: 0x00011A0A
			public unsafe static Encoding targetEncoding
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_targetEncoding, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_targetEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F21 RID: 7969
			private static readonly IntPtr NativeFieldInfoPtr_encodingLookup;

			// Token: 0x04001F22 RID: 7970
			private static readonly IntPtr NativeFieldInfoPtr_targetEncoding;
		}

		// Token: 0x020007BB RID: 1979
		public enum CreateOptions
		{
			// Token: 0x04001F24 RID: 7972
			None,
			// Token: 0x04001F25 RID: 7973
			CreateNativeObject
		}

		// Token: 0x020007BC RID: 1980
		// (Invoke) Token: 0x06002D73 RID: 11635
		private delegate IntPtr GetPreviewBytesDelegate(IntPtr @this, int maxByteCount);

		// Token: 0x020007BD RID: 1981
		// (Invoke) Token: 0x06002D75 RID: 11637
		private delegate void Internal_CreateInstanceDelegate(IntPtr self, IntPtr text);
	}
}
