using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000149 RID: 329
	public class Palette : ScriptableObject
	{
		// Token: 0x0600274D RID: 10061 RVA: 0x000A1848 File Offset: 0x0009FA48
		// Note: this type is marked as 'beforefieldinit'.
		static Palette()
		{
			Il2CppClassPointerStore<Palette>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Palette");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Palette>.NativeClassPtr);
			Palette.NativeFieldInfoPtr_ape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "ape");
			Palette.NativeFieldInfoPtr_apeBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "apeBlood");
			Palette.NativeFieldInfoPtr_floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "floor");
			Palette.NativeFieldInfoPtr_floorBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "floorBG");
			Palette.NativeFieldInfoPtr_wall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "wall");
			Palette.NativeFieldInfoPtr_wallBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "wallBG");
			Palette.NativeFieldInfoPtr_guard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "guard");
			Palette.NativeFieldInfoPtr_guardBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "guardBG");
			Palette.NativeFieldInfoPtr_blood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "blood");
			Palette.NativeFieldInfoPtr_bloodBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "bloodBG");
			Palette.NativeFieldInfoPtr_glass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "glass");
			Palette.NativeFieldInfoPtr_glassBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "glassBG");
			Palette.NativeFieldInfoPtr_flash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "flash");
			Palette.NativeFieldInfoPtr_flashBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "flashBG");
			Palette.NativeFieldInfoPtr_door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "door");
			Palette.NativeFieldInfoPtr_doorBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "doorBG");
			Palette.NativeFieldInfoPtr_cage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "cage");
			Palette.NativeFieldInfoPtr_cageBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "cageBG");
			Palette.NativeFieldInfoPtr_gun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "gun");
			Palette.NativeFieldInfoPtr_gunBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "gunBG");
			Palette.NativeFieldInfoPtr_vest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "vest");
			Palette.NativeFieldInfoPtr_fireBackpack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "fireBackpack");
			Palette.NativeFieldInfoPtr_halftone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "halftone");
			Palette.NativeFieldInfoPtr_fireCol1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "fireCol1");
			Palette.NativeFieldInfoPtr_fireCol2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "fireCol2");
			Palette.NativeFieldInfoPtr_dust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "dust");
			Palette.NativeFieldInfoPtr_wood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "wood");
			Palette.NativeFieldInfoPtr_woodBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "woodBG");
			Palette.NativeFieldInfoPtr_tree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "tree");
			Palette.NativeFieldInfoPtr_treeBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "treeBG");
			Palette.NativeFieldInfoPtr_rock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "rock");
			Palette.NativeFieldInfoPtr_rockBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "rockBG");
			Palette.NativeFieldInfoPtr_civ1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "civ1");
			Palette.NativeFieldInfoPtr_civ2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "civ2");
			Palette.NativeFieldInfoPtr_civ3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "civ3");
			Palette.NativeFieldInfoPtr_civ4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Palette>.NativeClassPtr, "civ4");
			Palette.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Palette>.NativeClassPtr, 100666472);
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x000A1B5C File Offset: 0x0009FD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75598, XrefRangeEnd = 75599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Palette()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Palette>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Palette.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x0001B4BC File Offset: 0x000196BC
		public Palette(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x000A1B98 File Offset: 0x0009FD98
		// (set) Token: 0x06002751 RID: 10065 RVA: 0x0001B4C5 File Offset: 0x000196C5
		public unsafe Color ape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_ape);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_ape)) = value;
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x000A1BC0 File Offset: 0x0009FDC0
		// (set) Token: 0x06002753 RID: 10067 RVA: 0x0001B4E0 File Offset: 0x000196E0
		public unsafe Color apeBlood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_apeBlood);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_apeBlood)) = value;
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06002754 RID: 10068 RVA: 0x000A1BE8 File Offset: 0x0009FDE8
		// (set) Token: 0x06002755 RID: 10069 RVA: 0x0001B4FB File Offset: 0x000196FB
		public unsafe Color floor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_floor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_floor)) = value;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06002756 RID: 10070 RVA: 0x000A1C10 File Offset: 0x0009FE10
		// (set) Token: 0x06002757 RID: 10071 RVA: 0x0001B516 File Offset: 0x00019716
		public unsafe Color floorBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_floorBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_floorBG)) = value;
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x000A1C38 File Offset: 0x0009FE38
		// (set) Token: 0x06002759 RID: 10073 RVA: 0x0001B531 File Offset: 0x00019731
		public unsafe Color wall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_wall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_wall)) = value;
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x000A1C60 File Offset: 0x0009FE60
		// (set) Token: 0x0600275B RID: 10075 RVA: 0x0001B54C File Offset: 0x0001974C
		public unsafe Color wallBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_wallBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_wallBG)) = value;
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x000A1C88 File Offset: 0x0009FE88
		// (set) Token: 0x0600275D RID: 10077 RVA: 0x0001B567 File Offset: 0x00019767
		public unsafe Color guard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_guard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_guard)) = value;
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x000A1CB0 File Offset: 0x0009FEB0
		// (set) Token: 0x0600275F RID: 10079 RVA: 0x0001B582 File Offset: 0x00019782
		public unsafe Color guardBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_guardBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_guardBG)) = value;
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x000A1CD8 File Offset: 0x0009FED8
		// (set) Token: 0x06002761 RID: 10081 RVA: 0x0001B59D File Offset: 0x0001979D
		public unsafe Color blood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_blood);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_blood)) = value;
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x000A1D00 File Offset: 0x0009FF00
		// (set) Token: 0x06002763 RID: 10083 RVA: 0x0001B5B8 File Offset: 0x000197B8
		public unsafe Color bloodBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_bloodBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_bloodBG)) = value;
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x000A1D28 File Offset: 0x0009FF28
		// (set) Token: 0x06002765 RID: 10085 RVA: 0x0001B5D3 File Offset: 0x000197D3
		public unsafe Color glass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_glass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_glass)) = value;
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x000A1D50 File Offset: 0x0009FF50
		// (set) Token: 0x06002767 RID: 10087 RVA: 0x0001B5EE File Offset: 0x000197EE
		public unsafe Color glassBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_glassBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_glassBG)) = value;
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x000A1D78 File Offset: 0x0009FF78
		// (set) Token: 0x06002769 RID: 10089 RVA: 0x0001B609 File Offset: 0x00019809
		public unsafe Color flash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_flash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_flash)) = value;
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x000A1DA0 File Offset: 0x0009FFA0
		// (set) Token: 0x0600276B RID: 10091 RVA: 0x0001B624 File Offset: 0x00019824
		public unsafe Color flashBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_flashBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_flashBG)) = value;
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x0600276C RID: 10092 RVA: 0x000A1DC8 File Offset: 0x0009FFC8
		// (set) Token: 0x0600276D RID: 10093 RVA: 0x0001B63F File Offset: 0x0001983F
		public unsafe Color door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_door);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_door)) = value;
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x000A1DF0 File Offset: 0x0009FFF0
		// (set) Token: 0x0600276F RID: 10095 RVA: 0x0001B65A File Offset: 0x0001985A
		public unsafe Color doorBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_doorBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_doorBG)) = value;
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06002770 RID: 10096 RVA: 0x000A1E18 File Offset: 0x000A0018
		// (set) Token: 0x06002771 RID: 10097 RVA: 0x0001B675 File Offset: 0x00019875
		public unsafe Color cage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_cage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_cage)) = value;
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06002772 RID: 10098 RVA: 0x000A1E40 File Offset: 0x000A0040
		// (set) Token: 0x06002773 RID: 10099 RVA: 0x0001B690 File Offset: 0x00019890
		public unsafe Color cageBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_cageBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_cageBG)) = value;
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06002774 RID: 10100 RVA: 0x000A1E68 File Offset: 0x000A0068
		// (set) Token: 0x06002775 RID: 10101 RVA: 0x0001B6AB File Offset: 0x000198AB
		public unsafe Color gun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_gun);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_gun)) = value;
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06002776 RID: 10102 RVA: 0x000A1E90 File Offset: 0x000A0090
		// (set) Token: 0x06002777 RID: 10103 RVA: 0x0001B6C6 File Offset: 0x000198C6
		public unsafe Color gunBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_gunBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_gunBG)) = value;
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x000A1EB8 File Offset: 0x000A00B8
		// (set) Token: 0x06002779 RID: 10105 RVA: 0x0001B6E1 File Offset: 0x000198E1
		public unsafe Color vest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_vest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_vest)) = value;
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x000A1EE0 File Offset: 0x000A00E0
		// (set) Token: 0x0600277B RID: 10107 RVA: 0x0001B6FC File Offset: 0x000198FC
		public unsafe Color fireBackpack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_fireBackpack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_fireBackpack)) = value;
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x0600277C RID: 10108 RVA: 0x000A1F08 File Offset: 0x000A0108
		// (set) Token: 0x0600277D RID: 10109 RVA: 0x0001B717 File Offset: 0x00019917
		public unsafe Color halftone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_halftone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_halftone)) = value;
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x0600277E RID: 10110 RVA: 0x000A1F30 File Offset: 0x000A0130
		// (set) Token: 0x0600277F RID: 10111 RVA: 0x0001B732 File Offset: 0x00019932
		public unsafe Color fireCol1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_fireCol1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_fireCol1)) = value;
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06002780 RID: 10112 RVA: 0x000A1F58 File Offset: 0x000A0158
		// (set) Token: 0x06002781 RID: 10113 RVA: 0x0001B74D File Offset: 0x0001994D
		public unsafe Color fireCol2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_fireCol2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_fireCol2)) = value;
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06002782 RID: 10114 RVA: 0x000A1F80 File Offset: 0x000A0180
		// (set) Token: 0x06002783 RID: 10115 RVA: 0x0001B768 File Offset: 0x00019968
		public unsafe Color dust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_dust);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_dust)) = value;
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x000A1FA8 File Offset: 0x000A01A8
		// (set) Token: 0x06002785 RID: 10117 RVA: 0x0001B783 File Offset: 0x00019983
		public unsafe Color wood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_wood);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_wood)) = value;
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x000A1FD0 File Offset: 0x000A01D0
		// (set) Token: 0x06002787 RID: 10119 RVA: 0x0001B79E File Offset: 0x0001999E
		public unsafe Color woodBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_woodBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_woodBG)) = value;
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06002788 RID: 10120 RVA: 0x000A1FF8 File Offset: 0x000A01F8
		// (set) Token: 0x06002789 RID: 10121 RVA: 0x0001B7B9 File Offset: 0x000199B9
		public unsafe Color tree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_tree);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_tree)) = value;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x0600278A RID: 10122 RVA: 0x000A2020 File Offset: 0x000A0220
		// (set) Token: 0x0600278B RID: 10123 RVA: 0x0001B7D4 File Offset: 0x000199D4
		public unsafe Color treeBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_treeBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_treeBG)) = value;
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x0600278C RID: 10124 RVA: 0x000A2048 File Offset: 0x000A0248
		// (set) Token: 0x0600278D RID: 10125 RVA: 0x0001B7EF File Offset: 0x000199EF
		public unsafe Color rock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_rock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_rock)) = value;
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x0600278E RID: 10126 RVA: 0x000A2070 File Offset: 0x000A0270
		// (set) Token: 0x0600278F RID: 10127 RVA: 0x0001B80A File Offset: 0x00019A0A
		public unsafe Color rockBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_rockBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_rockBG)) = value;
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06002790 RID: 10128 RVA: 0x000A2098 File Offset: 0x000A0298
		// (set) Token: 0x06002791 RID: 10129 RVA: 0x0001B825 File Offset: 0x00019A25
		public unsafe Color civ1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_civ1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_civ1)) = value;
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06002792 RID: 10130 RVA: 0x000A20C0 File Offset: 0x000A02C0
		// (set) Token: 0x06002793 RID: 10131 RVA: 0x0001B840 File Offset: 0x00019A40
		public unsafe Color civ2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_civ2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_civ2)) = value;
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x000A20E8 File Offset: 0x000A02E8
		// (set) Token: 0x06002795 RID: 10133 RVA: 0x0001B85B File Offset: 0x00019A5B
		public unsafe Color civ3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_civ3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_civ3)) = value;
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06002796 RID: 10134 RVA: 0x000A2110 File Offset: 0x000A0310
		// (set) Token: 0x06002797 RID: 10135 RVA: 0x0001B876 File Offset: 0x00019A76
		public unsafe Color civ4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_civ4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Palette.NativeFieldInfoPtr_civ4)) = value;
			}
		}

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeFieldInfoPtr_ape;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeFieldInfoPtr_apeBlood;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeFieldInfoPtr_floor;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeFieldInfoPtr_floorBG;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeFieldInfoPtr_wall;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeFieldInfoPtr_wallBG;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeFieldInfoPtr_guard;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeFieldInfoPtr_guardBG;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeFieldInfoPtr_blood;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeFieldInfoPtr_bloodBG;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeFieldInfoPtr_glass;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeFieldInfoPtr_glassBG;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeFieldInfoPtr_flash;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeFieldInfoPtr_flashBG;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeFieldInfoPtr_door;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeFieldInfoPtr_doorBG;

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeFieldInfoPtr_cage;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeFieldInfoPtr_cageBG;

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeFieldInfoPtr_gun;

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeFieldInfoPtr_gunBG;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeFieldInfoPtr_vest;

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeFieldInfoPtr_fireBackpack;

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeFieldInfoPtr_halftone;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeFieldInfoPtr_fireCol1;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeFieldInfoPtr_fireCol2;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeFieldInfoPtr_dust;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeFieldInfoPtr_wood;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeFieldInfoPtr_woodBG;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeFieldInfoPtr_tree;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeFieldInfoPtr_treeBG;

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeFieldInfoPtr_rock;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeFieldInfoPtr_rockBG;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeFieldInfoPtr_civ1;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeFieldInfoPtr_civ2;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeFieldInfoPtr_civ3;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeFieldInfoPtr_civ4;

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
