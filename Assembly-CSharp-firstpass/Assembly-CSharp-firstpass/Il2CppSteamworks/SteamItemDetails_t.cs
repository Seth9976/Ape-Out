using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200012D RID: 301
	[StructLayout(2)]
	public struct SteamItemDetails_t
	{
		// Token: 0x060009E9 RID: 2537 RVA: 0x0002FF38 File Offset: 0x0002E138
		// Note: this type is marked as 'beforefieldinit'.
		static SteamItemDetails_t()
		{
			Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamItemDetails_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr);
			SteamItemDetails_t.NativeFieldInfoPtr_m_itemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr, "m_itemId");
			SteamItemDetails_t.NativeFieldInfoPtr_m_iDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr, "m_iDefinition");
			SteamItemDetails_t.NativeFieldInfoPtr_m_unQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr, "m_unQuantity");
			SteamItemDetails_t.NativeFieldInfoPtr_m_unFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr, "m_unFlags");
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000060DD File Offset: 0x000042DD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeFieldInfoPtr_m_itemId;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeFieldInfoPtr_m_iDefinition;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeFieldInfoPtr_m_unQuantity;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeFieldInfoPtr_m_unFlags;

		// Token: 0x04000C99 RID: 3225
		[FieldOffset(0)]
		public SteamItemInstanceID_t m_itemId;

		// Token: 0x04000C9A RID: 3226
		[FieldOffset(8)]
		public SteamItemDef_t m_iDefinition;

		// Token: 0x04000C9B RID: 3227
		[FieldOffset(12)]
		public ushort m_unQuantity;

		// Token: 0x04000C9C RID: 3228
		[FieldOffset(14)]
		public ushort m_unFlags;
	}
}
