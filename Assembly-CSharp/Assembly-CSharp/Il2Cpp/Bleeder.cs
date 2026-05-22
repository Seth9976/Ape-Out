using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200007D RID: 125
	public class Bleeder : MonoBehaviour
	{
		// Token: 0x06001052 RID: 4178 RVA: 0x00063B10 File Offset: 0x00061D10
		// Note: this type is marked as 'beforefieldinit'.
		static Bleeder()
		{
			Il2CppClassPointerStore<Bleeder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Bleeder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bleeder>.NativeClassPtr);
			Bleeder.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bleeder>.NativeClassPtr, "state");
			Bleeder.NativeFieldInfoPtr_bleedPartSmall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bleeder>.NativeClassPtr, "bleedPartSmall");
			Bleeder.NativeFieldInfoPtr_bleedPartBig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bleeder>.NativeClassPtr, "bleedPartBig");
			Bleeder.NativeFieldInfoPtr_bleedParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bleeder>.NativeClassPtr, "bleedParts");
			Bleeder.NativeFieldInfoPtr_onAnimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bleeder>.NativeClassPtr, "onAnimal");
			Bleeder.NativeFieldInfoPtr_prevHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bleeder>.NativeClassPtr, "prevHealth");
			Bleeder.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bleeder>.NativeClassPtr, 100664670);
			Bleeder.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bleeder>.NativeClassPtr, 100664671);
			Bleeder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bleeder>.NativeClassPtr, 100664672);
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00063BF4 File Offset: 0x00061DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48105, XrefRangeEnd = 48143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bleeder.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00063C28 File Offset: 0x00061E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48143, XrefRangeEnd = 48153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bleeder.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00063C5C File Offset: 0x00061E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bleeder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bleeder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bleeder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0000C17B File Offset: 0x0000A37B
		public Bleeder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x00063C98 File Offset: 0x00061E98
		// (set) Token: 0x06001058 RID: 4184 RVA: 0x0000C184 File Offset: 0x0000A384
		public unsafe State state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bleeder.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<State>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bleeder.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x00063CC8 File Offset: 0x00061EC8
		// (set) Token: 0x0600105A RID: 4186 RVA: 0x0000C1A3 File Offset: 0x0000A3A3
		public unsafe GameObject bleedPartSmall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bleeder.NativeFieldInfoPtr_bleedPartSmall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bleeder.NativeFieldInfoPtr_bleedPartSmall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x00063CF8 File Offset: 0x00061EF8
		// (set) Token: 0x0600105C RID: 4188 RVA: 0x0000C1C2 File Offset: 0x0000A3C2
		public unsafe GameObject bleedPartBig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bleeder.NativeFieldInfoPtr_bleedPartBig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bleeder.NativeFieldInfoPtr_bleedPartBig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x00063D28 File Offset: 0x00061F28
		// (set) Token: 0x0600105E RID: 4190 RVA: 0x0000C1E1 File Offset: 0x0000A3E1
		public unsafe Il2CppReferenceArray<ParticleSystem> bleedParts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bleeder.NativeFieldInfoPtr_bleedParts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bleeder.NativeFieldInfoPtr_bleedParts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x0600105F RID: 4191 RVA: 0x00063D58 File Offset: 0x00061F58
		// (set) Token: 0x06001060 RID: 4192 RVA: 0x0000C200 File Offset: 0x0000A400
		public unsafe bool onAnimal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bleeder.NativeFieldInfoPtr_onAnimal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bleeder.NativeFieldInfoPtr_onAnimal)) = value;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x00063D80 File Offset: 0x00061F80
		// (set) Token: 0x06001062 RID: 4194 RVA: 0x0000C21B File Offset: 0x0000A41B
		public unsafe int prevHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bleeder.NativeFieldInfoPtr_prevHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bleeder.NativeFieldInfoPtr_prevHealth)) = value;
			}
		}

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeFieldInfoPtr_bleedPartSmall;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeFieldInfoPtr_bleedPartBig;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeFieldInfoPtr_bleedParts;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeFieldInfoPtr_onAnimal;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeFieldInfoPtr_prevHealth;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
