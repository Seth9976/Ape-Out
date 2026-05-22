using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x0200014D RID: 333
	public class SendPacketsElement : Object
	{
		// Token: 0x060015A6 RID: 5542 RVA: 0x000629A4 File Offset: 0x00060BA4
		// Note: this type is marked as 'beforefieldinit'.
		static SendPacketsElement()
		{
			Il2CppClassPointerStore<SendPacketsElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SendPacketsElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendPacketsElement>.NativeClassPtr);
			SendPacketsElement.NativeFieldInfoPtr_m_FilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketsElement>.NativeClassPtr, "m_FilePath");
			SendPacketsElement.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketsElement>.NativeClassPtr, "m_Buffer");
			SendPacketsElement.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketsElement>.NativeClassPtr, "m_Offset");
			SendPacketsElement.NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketsElement>.NativeClassPtr, "m_Count");
			SendPacketsElement.NativeFieldInfoPtr_m_endOfPacket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketsElement>.NativeClassPtr, "m_endOfPacket");
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x0000ABB0 File Offset: 0x00008DB0
		public SendPacketsElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x00062A38 File Offset: 0x00060C38
		// (set) Token: 0x060015A9 RID: 5545 RVA: 0x0000ABB9 File Offset: 0x00008DB9
		public unsafe string m_FilePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendPacketsElement.NativeFieldInfoPtr_m_FilePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendPacketsElement.NativeFieldInfoPtr_m_FilePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x00062A60 File Offset: 0x00060C60
		// (set) Token: 0x060015AB RID: 5547 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		public unsafe Il2CppStructArray<byte> m_Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendPacketsElement.NativeFieldInfoPtr_m_Buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendPacketsElement.NativeFieldInfoPtr_m_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x00062A90 File Offset: 0x00060C90
		// (set) Token: 0x060015AD RID: 5549 RVA: 0x0000ABF7 File Offset: 0x00008DF7
		public unsafe int m_Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendPacketsElement.NativeFieldInfoPtr_m_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendPacketsElement.NativeFieldInfoPtr_m_Offset)) = value;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x00062AB8 File Offset: 0x00060CB8
		// (set) Token: 0x060015AF RID: 5551 RVA: 0x0000AC12 File Offset: 0x00008E12
		public unsafe int m_Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendPacketsElement.NativeFieldInfoPtr_m_Count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendPacketsElement.NativeFieldInfoPtr_m_Count)) = value;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x00062AE0 File Offset: 0x00060CE0
		// (set) Token: 0x060015B1 RID: 5553 RVA: 0x0000AC2D File Offset: 0x00008E2D
		public unsafe bool m_endOfPacket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendPacketsElement.NativeFieldInfoPtr_m_endOfPacket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendPacketsElement.NativeFieldInfoPtr_m_endOfPacket)) = value;
			}
		}

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeFieldInfoPtr_m_FilePath;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeFieldInfoPtr_m_Offset;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeFieldInfoPtr_m_Count;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeFieldInfoPtr_m_endOfPacket;
	}
}
