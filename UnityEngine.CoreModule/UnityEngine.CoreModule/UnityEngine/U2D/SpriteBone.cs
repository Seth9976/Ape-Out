using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D
{
	// Token: 0x0200010B RID: 267
	[Serializable]
	public sealed class SpriteBone : ValueType
	{
		// Token: 0x060016C8 RID: 5832 RVA: 0x00058CEC File Offset: 0x00056EEC
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteBone()
		{
			Il2CppClassPointerStore<SpriteBone>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteBone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr);
			SpriteBone.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Name");
			SpriteBone.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Position");
			SpriteBone.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Rotation");
			SpriteBone.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Length");
			SpriteBone.NativeFieldInfoPtr_m_ParentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_ParentId");
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x0000C2F3 File Offset: 0x0000A4F3
		public SpriteBone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x0000C2FC File Offset: 0x0000A4FC
		public SpriteBone()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr))
		{
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060016CB RID: 5835 RVA: 0x00058D80 File Offset: 0x00056F80
		// (set) Token: 0x060016CC RID: 5836 RVA: 0x0000C30E File Offset: 0x0000A50E
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x00058DA8 File Offset: 0x00056FA8
		// (set) Token: 0x060016CE RID: 5838 RVA: 0x0000C32D File Offset: 0x0000A52D
		public unsafe Vector3 m_Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Position)) = value;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x00058DD0 File Offset: 0x00056FD0
		// (set) Token: 0x060016D0 RID: 5840 RVA: 0x0000C348 File Offset: 0x0000A548
		public unsafe Quaternion m_Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Rotation)) = value;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x00058DF8 File Offset: 0x00056FF8
		// (set) Token: 0x060016D2 RID: 5842 RVA: 0x0000C363 File Offset: 0x0000A563
		public unsafe float m_Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Length)) = value;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x00058E20 File Offset: 0x00057020
		// (set) Token: 0x060016D4 RID: 5844 RVA: 0x0000C37E File Offset: 0x0000A57E
		public unsafe int m_ParentId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_ParentId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_ParentId)) = value;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x00058E48 File Offset: 0x00057048
		// (set) Token: 0x060016D6 RID: 5846 RVA: 0x0000C399 File Offset: 0x0000A599
		public string name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x00058E60 File Offset: 0x00057060
		// (set) Token: 0x060016D8 RID: 5848 RVA: 0x0000C3A3 File Offset: 0x0000A5A3
		public Vector3 position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				this.m_Position = value;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x00058E78 File Offset: 0x00057078
		// (set) Token: 0x060016DA RID: 5850 RVA: 0x0000C3AD File Offset: 0x0000A5AD
		public Quaternion rotation
		{
			get
			{
				return this.m_Rotation;
			}
			set
			{
				this.m_Rotation = value;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x00058E90 File Offset: 0x00057090
		// (set) Token: 0x060016DC RID: 5852 RVA: 0x0000C3B7 File Offset: 0x0000A5B7
		public float length
		{
			get
			{
				return this.m_Length;
			}
			set
			{
				this.m_Length = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x00058EA8 File Offset: 0x000570A8
		// (set) Token: 0x060016DE RID: 5854 RVA: 0x0000C3C1 File Offset: 0x0000A5C1
		public int parentId
		{
			get
			{
				return this.m_ParentId;
			}
			set
			{
				this.m_ParentId = value;
			}
		}

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeFieldInfoPtr_m_Rotation;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeFieldInfoPtr_m_Length;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentId;
	}
}
