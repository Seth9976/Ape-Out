using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	public sealed class HumanBone : ValueType
	{
		// Token: 0x06000241 RID: 577 RVA: 0x00009BBC File Offset: 0x00007DBC
		// Note: this type is marked as 'beforefieldinit'.
		static HumanBone()
		{
			Il2CppClassPointerStore<HumanBone>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "HumanBone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HumanBone>.NativeClassPtr);
			HumanBone.NativeFieldInfoPtr_m_BoneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, "m_BoneName");
			HumanBone.NativeFieldInfoPtr_m_HumanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, "m_HumanName");
			HumanBone.NativeFieldInfoPtr_limit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, "limit");
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00003729 File Offset: 0x00001929
		public HumanBone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00003732 File Offset: 0x00001932
		public HumanBone()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HumanBone>.NativeClassPtr))
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00009C28 File Offset: 0x00007E28
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00003744 File Offset: 0x00001944
		public unsafe string m_BoneName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_m_BoneName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_m_BoneName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00009C50 File Offset: 0x00007E50
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00003763 File Offset: 0x00001963
		public unsafe string m_HumanName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_m_HumanName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_m_HumanName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00009C78 File Offset: 0x00007E78
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00003782 File Offset: 0x00001982
		public unsafe HumanLimit limit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_limit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_limit)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00009CA0 File Offset: 0x00007EA0
		// (set) Token: 0x0600024B RID: 587 RVA: 0x0000379D File Offset: 0x0000199D
		public string boneName
		{
			get
			{
				return this.m_BoneName;
			}
			set
			{
				this.m_BoneName = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00009CB8 File Offset: 0x00007EB8
		// (set) Token: 0x0600024D RID: 589 RVA: 0x000037A7 File Offset: 0x000019A7
		public string humanName
		{
			get
			{
				return this.m_HumanName;
			}
			set
			{
				this.m_HumanName = value;
			}
		}

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_m_BoneName;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_m_HumanName;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_limit;
	}
}
