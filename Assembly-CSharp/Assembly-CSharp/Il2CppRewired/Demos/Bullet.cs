using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppRewired.Demos
{
	// Token: 0x02000219 RID: 537
	public class Bullet : MonoBehaviour
	{
		// Token: 0x0600414E RID: 16718 RVA: 0x000F36C4 File Offset: 0x000F18C4
		// Note: this type is marked as 'beforefieldinit'.
		static Bullet()
		{
			Il2CppClassPointerStore<Bullet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "Bullet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bullet>.NativeClassPtr);
			Bullet.NativeFieldInfoPtr_lifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bullet>.NativeClassPtr, "lifeTime");
			Bullet.NativeFieldInfoPtr_die = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bullet>.NativeClassPtr, "die");
			Bullet.NativeFieldInfoPtr_deathTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bullet>.NativeClassPtr, "deathTime");
			Bullet.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bullet>.NativeClassPtr, 100669667);
			Bullet.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bullet>.NativeClassPtr, 100669668);
			Bullet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bullet>.NativeClassPtr, 100669669);
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x000F376C File Offset: 0x000F196C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104937, XrefRangeEnd = 104939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bullet.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x000F37A0 File Offset: 0x000F19A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104939, XrefRangeEnd = 104947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bullet.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x000F37D4 File Offset: 0x000F19D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104947, XrefRangeEnd = 104950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bullet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bullet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bullet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x00027DA8 File Offset: 0x00025FA8
		public Bullet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x000F3810 File Offset: 0x000F1A10
		// (set) Token: 0x06004154 RID: 16724 RVA: 0x00027DB1 File Offset: 0x00025FB1
		public unsafe float lifeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bullet.NativeFieldInfoPtr_lifeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bullet.NativeFieldInfoPtr_lifeTime)) = value;
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06004155 RID: 16725 RVA: 0x000F3838 File Offset: 0x000F1A38
		// (set) Token: 0x06004156 RID: 16726 RVA: 0x00027DCC File Offset: 0x00025FCC
		public unsafe bool die
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bullet.NativeFieldInfoPtr_die);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bullet.NativeFieldInfoPtr_die)) = value;
			}
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06004157 RID: 16727 RVA: 0x000F3860 File Offset: 0x000F1A60
		// (set) Token: 0x06004158 RID: 16728 RVA: 0x00027DE7 File Offset: 0x00025FE7
		public unsafe float deathTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bullet.NativeFieldInfoPtr_deathTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bullet.NativeFieldInfoPtr_deathTime)) = value;
			}
		}

		// Token: 0x0400281F RID: 10271
		private static readonly IntPtr NativeFieldInfoPtr_lifeTime;

		// Token: 0x04002820 RID: 10272
		private static readonly IntPtr NativeFieldInfoPtr_die;

		// Token: 0x04002821 RID: 10273
		private static readonly IntPtr NativeFieldInfoPtr_deathTime;

		// Token: 0x04002822 RID: 10274
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04002823 RID: 10275
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002824 RID: 10276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
