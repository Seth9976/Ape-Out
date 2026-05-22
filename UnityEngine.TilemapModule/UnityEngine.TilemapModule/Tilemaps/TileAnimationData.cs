using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000009 RID: 9
	public sealed class TileAnimationData : ValueType
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x000043F8 File Offset: 0x000025F8
		// Note: this type is marked as 'beforefieldinit'.
		static TileAnimationData()
		{
			Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "TileAnimationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr);
			TileAnimationData.NativeFieldInfoPtr_m_AnimatedSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr, "m_AnimatedSprites");
			TileAnimationData.NativeFieldInfoPtr_m_AnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr, "m_AnimationSpeed");
			TileAnimationData.NativeFieldInfoPtr_m_AnimationStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr, "m_AnimationStartTime");
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000284C File Offset: 0x00000A4C
		public TileAnimationData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002855 File Offset: 0x00000A55
		public TileAnimationData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr))
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00004464 File Offset: 0x00002664
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002867 File Offset: 0x00000A67
		public unsafe Il2CppReferenceArray<Sprite> m_AnimatedSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimatedSprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimatedSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00004494 File Offset: 0x00002694
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00002886 File Offset: 0x00000A86
		public unsafe float m_AnimationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimationSpeed)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000044BC File Offset: 0x000026BC
		// (set) Token: 0x060000DC RID: 220 RVA: 0x000028A1 File Offset: 0x00000AA1
		public unsafe float m_AnimationStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimationStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimationStartTime)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000044E4 File Offset: 0x000026E4
		// (set) Token: 0x060000DE RID: 222 RVA: 0x000028BC File Offset: 0x00000ABC
		public Il2CppReferenceArray<Sprite> animatedSprites
		{
			get
			{
				return this.m_AnimatedSprites;
			}
			set
			{
				this.m_AnimatedSprites = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000DF RID: 223 RVA: 0x000044FC File Offset: 0x000026FC
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x000028C6 File Offset: 0x00000AC6
		public float animationSpeed
		{
			get
			{
				return this.m_AnimationSpeed;
			}
			set
			{
				this.m_AnimationSpeed = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00004514 File Offset: 0x00002714
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x000028D0 File Offset: 0x00000AD0
		public float animationStartTime
		{
			get
			{
				return this.m_AnimationStartTime;
			}
			set
			{
				this.m_AnimationStartTime = value;
			}
		}

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimatedSprites;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimationSpeed;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimationStartTime;
	}
}
