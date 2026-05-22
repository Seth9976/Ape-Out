using System;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000032 RID: 50
	public class ParticleSystemExtensionsImpl
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x0000279F File Offset: 0x0000099F
		public static int GetSafeCollisionEventSize(ParticleSystem ps)
		{
			return ParticleSystemExtensionsImpl.GetSafeCollisionEventSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(ps));
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000027B1 File Offset: 0x000009B1
		public static int GetSafeTriggerParticlesSize(ParticleSystem ps, int type)
		{
			return ParticleSystemExtensionsImpl.GetSafeTriggerParticlesSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(ps), type);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000027C4 File Offset: 0x000009C4
		public static int GetTriggerParticles(ParticleSystem ps, int type, List<ParticleSystem.Particle> particles)
		{
			return ParticleSystemExtensionsImpl.GetTriggerParticlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(ps), type, IL2CPP.Il2CppObjectBaseToPtr(particles));
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000027DD File Offset: 0x000009DD
		public static void SetTriggerParticles(ParticleSystem ps, int type, List<ParticleSystem.Particle> particles, int offset, int count)
		{
			ParticleSystemExtensionsImpl.SetTriggerParticlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(ps), type, IL2CPP.Il2CppObjectBaseToPtr(particles), offset, count);
		}

		// Token: 0x0400015E RID: 350
		private static readonly ParticleSystemExtensionsImpl.GetSafeCollisionEventSizeDelegate GetSafeCollisionEventSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemExtensionsImpl.GetSafeCollisionEventSizeDelegate>("UnityEngine.ParticleSystemExtensionsImpl::GetSafeCollisionEventSize");

		// Token: 0x0400015F RID: 351
		private static readonly ParticleSystemExtensionsImpl.GetSafeTriggerParticlesSizeDelegate GetSafeTriggerParticlesSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemExtensionsImpl.GetSafeTriggerParticlesSizeDelegate>("UnityEngine.ParticleSystemExtensionsImpl::GetSafeTriggerParticlesSize");

		// Token: 0x04000160 RID: 352
		private static readonly ParticleSystemExtensionsImpl.GetTriggerParticlesDelegate GetTriggerParticlesDelegateField = IL2CPP.ResolveICall<ParticleSystemExtensionsImpl.GetTriggerParticlesDelegate>("UnityEngine.ParticleSystemExtensionsImpl::GetTriggerParticles");

		// Token: 0x04000161 RID: 353
		private static readonly ParticleSystemExtensionsImpl.SetTriggerParticlesDelegate SetTriggerParticlesDelegateField = IL2CPP.ResolveICall<ParticleSystemExtensionsImpl.SetTriggerParticlesDelegate>("UnityEngine.ParticleSystemExtensionsImpl::SetTriggerParticles");

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060001E2 RID: 482
		private delegate int GetSafeCollisionEventSizeDelegate(IntPtr ps);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060001E4 RID: 484
		private delegate int GetSafeTriggerParticlesSizeDelegate(IntPtr ps, int type);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060001E6 RID: 486
		private delegate int GetTriggerParticlesDelegate(IntPtr ps, int type, IntPtr particles);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060001E8 RID: 488
		private delegate void SetTriggerParticlesDelegate(IntPtr ps, int type, IntPtr particles, int offset, int count);
	}
}
