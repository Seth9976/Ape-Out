using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x0200011C RID: 284
	[Serializable]
	public class Bag : Object
	{
		// Token: 0x06002270 RID: 8816 RVA: 0x00093F54 File Offset: 0x00092154
		// Note: this type is marked as 'beforefieldinit'.
		static Bag()
		{
			Il2CppClassPointerStore<Bag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Bag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bag>.NativeClassPtr);
			Bag.NativeFieldInfoPtr_bagType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bag>.NativeClassPtr, "bagType");
			Bag.NativeFieldInfoPtr_bagWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bag>.NativeClassPtr, "bagWeight");
			Bag.NativeFieldInfoPtr_palNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bag>.NativeClassPtr, "palNum");
			Bag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bag>.NativeClassPtr, 100665965);
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x00093FD4 File Offset: 0x000921D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x00018316 File Offset: 0x00016516
		public Bag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x00094010 File Offset: 0x00092210
		// (set) Token: 0x06002274 RID: 8820 RVA: 0x0001831F File Offset: 0x0001651F
		public unsafe Bag.BagType bagType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bag.NativeFieldInfoPtr_bagType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bag.NativeFieldInfoPtr_bagType)) = value;
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06002275 RID: 8821 RVA: 0x00094038 File Offset: 0x00092238
		// (set) Token: 0x06002276 RID: 8822 RVA: 0x0001833A File Offset: 0x0001653A
		public unsafe int bagWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bag.NativeFieldInfoPtr_bagWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bag.NativeFieldInfoPtr_bagWeight)) = value;
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06002277 RID: 8823 RVA: 0x00094060 File Offset: 0x00092260
		// (set) Token: 0x06002278 RID: 8824 RVA: 0x00018355 File Offset: 0x00016555
		public unsafe int palNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bag.NativeFieldInfoPtr_palNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bag.NativeFieldInfoPtr_palNum)) = value;
			}
		}

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeFieldInfoPtr_bagType;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeFieldInfoPtr_bagWeight;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeFieldInfoPtr_palNum;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000317 RID: 791
		[OriginalName("Assembly-CSharp.dll", "", "BagType")]
		public enum BagType
		{
			// Token: 0x040034E9 RID: 13545
			labOpen,
			// Token: 0x040034EA RID: 13546
			labTight,
			// Token: 0x040034EB RID: 13547
			stealth,
			// Token: 0x040034EC RID: 13548
			hall,
			// Token: 0x040034ED RID: 13549
			bunkerHalls,
			// Token: 0x040034EE RID: 13550
			bunkerRooms,
			// Token: 0x040034EF RID: 13551
			outdoor,
			// Token: 0x040034F0 RID: 13552
			outdoorBuilding,
			// Token: 0x040034F1 RID: 13553
			office,
			// Token: 0x040034F2 RID: 13554
			hanger,
			// Token: 0x040034F3 RID: 13555
			bear,
			// Token: 0x040034F4 RID: 13556
			zoo,
			// Token: 0x040034F5 RID: 13557
			zooBS,
			// Token: 0x040034F6 RID: 13558
			zooOutdoor,
			// Token: 0x040034F7 RID: 13559
			zooOutdoorHab,
			// Token: 0x040034F8 RID: 13560
			boat,
			// Token: 0x040034F9 RID: 13561
			boatCrew,
			// Token: 0x040034FA RID: 13562
			boatDeck,
			// Token: 0x040034FB RID: 13563
			boatHarbor,
			// Token: 0x040034FC RID: 13564
			officeConstruction,
			// Token: 0x040034FD RID: 13565
			officeLobby,
			// Token: 0x040034FE RID: 13566
			bunkerIndoorHanger,
			// Token: 0x040034FF RID: 13567
			bunkerRoomBlown,
			// Token: 0x04003500 RID: 13568
			bunkerHallBlown
		}
	}
}
