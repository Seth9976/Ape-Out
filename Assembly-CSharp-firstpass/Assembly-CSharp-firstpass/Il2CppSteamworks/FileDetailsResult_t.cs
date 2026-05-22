using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000027 RID: 39
	public sealed class FileDetailsResult_t : ValueType
	{
		// Token: 0x0600049F RID: 1183 RVA: 0x000265A4 File Offset: 0x000247A4
		// Note: this type is marked as 'beforefieldinit'.
		static FileDetailsResult_t()
		{
			Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FileDetailsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr);
			FileDetailsResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, "k_iCallback");
			FileDetailsResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, "m_eResult");
			FileDetailsResult_t.NativeFieldInfoPtr_m_ulFileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, "m_ulFileSize");
			FileDetailsResult_t.NativeFieldInfoPtr_m_FileSHA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, "m_FileSHA");
			FileDetailsResult_t.NativeFieldInfoPtr_m_unFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, "m_unFlags");
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002C11 File Offset: 0x00000E11
		public FileDetailsResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00002C1A File Offset: 0x00000E1A
		public FileDetailsResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00026638 File Offset: 0x00024838
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x00002C2C File Offset: 0x00000E2C
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FileDetailsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileDetailsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00026654 File Offset: 0x00024854
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00002C3A File Offset: 0x00000E3A
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0002667C File Offset: 0x0002487C
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00002C55 File Offset: 0x00000E55
		public unsafe ulong m_ulFileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_ulFileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_ulFileSize)) = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x000266A4 File Offset: 0x000248A4
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00002C70 File Offset: 0x00000E70
		public unsafe Il2CppStructArray<byte> m_FileSHA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_FileSHA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_FileSHA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x000266D4 File Offset: 0x000248D4
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x00002C8F File Offset: 0x00000E8F
		public unsafe uint m_unFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_unFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_unFlags)) = value;
			}
		}

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr_m_ulFileSize;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr_m_FileSHA;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr_m_unFlags;
	}
}
