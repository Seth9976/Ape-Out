using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x0200014A RID: 330
	[StructLayout(2)]
	public struct PreLateUpdate
	{
		// Token: 0x06001984 RID: 6532 RVA: 0x0000D670 File Offset: 0x0000B870
		// Note: this type is marked as 'beforefieldinit'.
		static PreLateUpdate()
		{
			Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "PreLateUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x0000D695 File Offset: 0x0000B895
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x020008FD RID: 2301
		[StructLayout(2)]
		public struct Physics2DLateUpdate
		{
			// Token: 0x06003077 RID: 12407 RVA: 0x0001496A File Offset: 0x00012B6A
			// Note: this type is marked as 'beforefieldinit'.
			static Physics2DLateUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.Physics2DLateUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "Physics2DLateUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.Physics2DLateUpdate>.NativeClassPtr);
			}

			// Token: 0x06003078 RID: 12408 RVA: 0x0001498A File Offset: 0x00012B8A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.Physics2DLateUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008FE RID: 2302
		[StructLayout(2)]
		public struct AIUpdatePostScript
		{
			// Token: 0x06003079 RID: 12409 RVA: 0x0001499C File Offset: 0x00012B9C
			// Note: this type is marked as 'beforefieldinit'.
			static AIUpdatePostScript()
			{
				Il2CppClassPointerStore<PreLateUpdate.AIUpdatePostScript>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "AIUpdatePostScript");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.AIUpdatePostScript>.NativeClassPtr);
			}

			// Token: 0x0600307A RID: 12410 RVA: 0x000149BC File Offset: 0x00012BBC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.AIUpdatePostScript>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008FF RID: 2303
		[StructLayout(2)]
		public struct DirectorUpdateAnimationBegin
		{
			// Token: 0x0600307B RID: 12411 RVA: 0x000149CE File Offset: 0x00012BCE
			// Note: this type is marked as 'beforefieldinit'.
			static DirectorUpdateAnimationBegin()
			{
				Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationBegin>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "DirectorUpdateAnimationBegin");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationBegin>.NativeClassPtr);
			}

			// Token: 0x0600307C RID: 12412 RVA: 0x000149EE File Offset: 0x00012BEE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationBegin>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000900 RID: 2304
		[StructLayout(2)]
		public struct LegacyAnimationUpdate
		{
			// Token: 0x0600307D RID: 12413 RVA: 0x00014A00 File Offset: 0x00012C00
			// Note: this type is marked as 'beforefieldinit'.
			static LegacyAnimationUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.LegacyAnimationUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "LegacyAnimationUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.LegacyAnimationUpdate>.NativeClassPtr);
			}

			// Token: 0x0600307E RID: 12414 RVA: 0x00014A20 File Offset: 0x00012C20
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.LegacyAnimationUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000901 RID: 2305
		[StructLayout(2)]
		public struct DirectorUpdateAnimationEnd
		{
			// Token: 0x0600307F RID: 12415 RVA: 0x00014A32 File Offset: 0x00012C32
			// Note: this type is marked as 'beforefieldinit'.
			static DirectorUpdateAnimationEnd()
			{
				Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationEnd>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "DirectorUpdateAnimationEnd");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationEnd>.NativeClassPtr);
			}

			// Token: 0x06003080 RID: 12416 RVA: 0x00014A52 File Offset: 0x00012C52
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationEnd>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000902 RID: 2306
		[StructLayout(2)]
		public struct DirectorDeferredEvaluate
		{
			// Token: 0x06003081 RID: 12417 RVA: 0x00014A64 File Offset: 0x00012C64
			// Note: this type is marked as 'beforefieldinit'.
			static DirectorDeferredEvaluate()
			{
				Il2CppClassPointerStore<PreLateUpdate.DirectorDeferredEvaluate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "DirectorDeferredEvaluate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.DirectorDeferredEvaluate>.NativeClassPtr);
			}

			// Token: 0x06003082 RID: 12418 RVA: 0x00014A84 File Offset: 0x00012C84
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.DirectorDeferredEvaluate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000903 RID: 2307
		[StructLayout(2)]
		public struct UIElementsUpdatePanels
		{
			// Token: 0x06003083 RID: 12419 RVA: 0x00014A96 File Offset: 0x00012C96
			// Note: this type is marked as 'beforefieldinit'.
			static UIElementsUpdatePanels()
			{
				Il2CppClassPointerStore<PreLateUpdate.UIElementsUpdatePanels>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "UIElementsUpdatePanels");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.UIElementsUpdatePanels>.NativeClassPtr);
			}

			// Token: 0x06003084 RID: 12420 RVA: 0x00014AB6 File Offset: 0x00012CB6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.UIElementsUpdatePanels>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000904 RID: 2308
		[StructLayout(2)]
		public struct UpdateNetworkManager
		{
			// Token: 0x06003085 RID: 12421 RVA: 0x00014AC8 File Offset: 0x00012CC8
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateNetworkManager()
			{
				Il2CppClassPointerStore<PreLateUpdate.UpdateNetworkManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "UpdateNetworkManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.UpdateNetworkManager>.NativeClassPtr);
			}

			// Token: 0x06003086 RID: 12422 RVA: 0x00014AE8 File Offset: 0x00012CE8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.UpdateNetworkManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000905 RID: 2309
		[StructLayout(2)]
		public struct UpdateMasterServerInterface
		{
			// Token: 0x06003087 RID: 12423 RVA: 0x00014AFA File Offset: 0x00012CFA
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateMasterServerInterface()
			{
				Il2CppClassPointerStore<PreLateUpdate.UpdateMasterServerInterface>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "UpdateMasterServerInterface");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.UpdateMasterServerInterface>.NativeClassPtr);
			}

			// Token: 0x06003088 RID: 12424 RVA: 0x00014B1A File Offset: 0x00012D1A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.UpdateMasterServerInterface>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000906 RID: 2310
		[StructLayout(2)]
		public struct UNetUpdate
		{
			// Token: 0x06003089 RID: 12425 RVA: 0x00014B2C File Offset: 0x00012D2C
			// Note: this type is marked as 'beforefieldinit'.
			static UNetUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.UNetUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "UNetUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.UNetUpdate>.NativeClassPtr);
			}

			// Token: 0x0600308A RID: 12426 RVA: 0x00014B4C File Offset: 0x00012D4C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.UNetUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000907 RID: 2311
		[StructLayout(2)]
		public struct EndGraphicsJobsAfterScriptUpdate
		{
			// Token: 0x0600308B RID: 12427 RVA: 0x00014B5E File Offset: 0x00012D5E
			// Note: this type is marked as 'beforefieldinit'.
			static EndGraphicsJobsAfterScriptUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.EndGraphicsJobsAfterScriptUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "EndGraphicsJobsAfterScriptUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.EndGraphicsJobsAfterScriptUpdate>.NativeClassPtr);
			}

			// Token: 0x0600308C RID: 12428 RVA: 0x00014B7E File Offset: 0x00012D7E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.EndGraphicsJobsAfterScriptUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000908 RID: 2312
		[StructLayout(2)]
		public struct ParticleSystemBeginUpdateAll
		{
			// Token: 0x0600308D RID: 12429 RVA: 0x00014B90 File Offset: 0x00012D90
			// Note: this type is marked as 'beforefieldinit'.
			static ParticleSystemBeginUpdateAll()
			{
				Il2CppClassPointerStore<PreLateUpdate.ParticleSystemBeginUpdateAll>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "ParticleSystemBeginUpdateAll");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.ParticleSystemBeginUpdateAll>.NativeClassPtr);
			}

			// Token: 0x0600308E RID: 12430 RVA: 0x00014BB0 File Offset: 0x00012DB0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.ParticleSystemBeginUpdateAll>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000909 RID: 2313
		[StructLayout(2)]
		public struct ScriptRunBehaviourLateUpdate
		{
			// Token: 0x0600308F RID: 12431 RVA: 0x00014BC2 File Offset: 0x00012DC2
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunBehaviourLateUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.ScriptRunBehaviourLateUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "ScriptRunBehaviourLateUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.ScriptRunBehaviourLateUpdate>.NativeClassPtr);
			}

			// Token: 0x06003090 RID: 12432 RVA: 0x00014BE2 File Offset: 0x00012DE2
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.ScriptRunBehaviourLateUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x0200090A RID: 2314
		[StructLayout(2)]
		public struct ConstraintManagerUpdate
		{
			// Token: 0x06003091 RID: 12433 RVA: 0x00014BF4 File Offset: 0x00012DF4
			// Note: this type is marked as 'beforefieldinit'.
			static ConstraintManagerUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.ConstraintManagerUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "ConstraintManagerUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.ConstraintManagerUpdate>.NativeClassPtr);
			}

			// Token: 0x06003092 RID: 12434 RVA: 0x00014C14 File Offset: 0x00012E14
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.ConstraintManagerUpdate>.NativeClassPtr, ref this));
			}
		}
	}
}
