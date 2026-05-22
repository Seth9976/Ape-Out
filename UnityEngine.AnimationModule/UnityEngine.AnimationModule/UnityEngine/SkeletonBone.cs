using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	public sealed class SkeletonBone : ValueType
	{
		// Token: 0x06000226 RID: 550 RVA: 0x0000993C File Offset: 0x00007B3C
		// Note: this type is marked as 'beforefieldinit'.
		static SkeletonBone()
		{
			Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "SkeletonBone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr);
			SkeletonBone.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr, "name");
			SkeletonBone.NativeFieldInfoPtr_parentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr, "parentName");
			SkeletonBone.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr, "position");
			SkeletonBone.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr, "rotation");
			SkeletonBone.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr, "scale");
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00003632 File Offset: 0x00001832
		public SkeletonBone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000363B File Offset: 0x0000183B
		public SkeletonBone()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr))
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000229 RID: 553 RVA: 0x000099D0 File Offset: 0x00007BD0
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0000364D File Offset: 0x0000184D
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600022B RID: 555 RVA: 0x000099F8 File Offset: 0x00007BF8
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0000366C File Offset: 0x0000186C
		public unsafe string parentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_parentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_parentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00009A20 File Offset: 0x00007C20
		// (set) Token: 0x0600022E RID: 558 RVA: 0x0000368B File Offset: 0x0000188B
		public unsafe Vector3 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00009A48 File Offset: 0x00007C48
		// (set) Token: 0x06000230 RID: 560 RVA: 0x000036A6 File Offset: 0x000018A6
		public unsafe Quaternion rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00009A70 File Offset: 0x00007C70
		// (set) Token: 0x06000232 RID: 562 RVA: 0x000036C1 File Offset: 0x000018C1
		public unsafe Vector3 scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00009A98 File Offset: 0x00007C98
		// (set) Token: 0x06000234 RID: 564 RVA: 0x000036DC File Offset: 0x000018DC
		public int transformModified
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_parentName;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_scale;
	}
}
