using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x02000148 RID: 328
	[StructLayout(2)]
	public struct PreUpdate
	{
		// Token: 0x06001980 RID: 6528 RVA: 0x0000D602 File Offset: 0x0000B802
		// Note: this type is marked as 'beforefieldinit'.
		static PreUpdate()
		{
			Il2CppClassPointerStore<PreUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "PreUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x0000D627 File Offset: 0x0000B827
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x020008F0 RID: 2288
		[StructLayout(2)]
		public struct PhysicsUpdate
		{
			// Token: 0x0600305D RID: 12381 RVA: 0x000146E0 File Offset: 0x000128E0
			// Note: this type is marked as 'beforefieldinit'.
			static PhysicsUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.PhysicsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "PhysicsUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.PhysicsUpdate>.NativeClassPtr);
			}

			// Token: 0x0600305E RID: 12382 RVA: 0x00014700 File Offset: 0x00012900
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.PhysicsUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F1 RID: 2289
		[StructLayout(2)]
		public struct Physics2DUpdate
		{
			// Token: 0x0600305F RID: 12383 RVA: 0x00014712 File Offset: 0x00012912
			// Note: this type is marked as 'beforefieldinit'.
			static Physics2DUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.Physics2DUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "Physics2DUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.Physics2DUpdate>.NativeClassPtr);
			}

			// Token: 0x06003060 RID: 12384 RVA: 0x00014732 File Offset: 0x00012932
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.Physics2DUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F2 RID: 2290
		[StructLayout(2)]
		public struct CheckTexFieldInput
		{
			// Token: 0x06003061 RID: 12385 RVA: 0x00014744 File Offset: 0x00012944
			// Note: this type is marked as 'beforefieldinit'.
			static CheckTexFieldInput()
			{
				Il2CppClassPointerStore<PreUpdate.CheckTexFieldInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "CheckTexFieldInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.CheckTexFieldInput>.NativeClassPtr);
			}

			// Token: 0x06003062 RID: 12386 RVA: 0x00014764 File Offset: 0x00012964
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.CheckTexFieldInput>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F3 RID: 2291
		[StructLayout(2)]
		public struct IMGUISendQueuedEvents
		{
			// Token: 0x06003063 RID: 12387 RVA: 0x00014776 File Offset: 0x00012976
			// Note: this type is marked as 'beforefieldinit'.
			static IMGUISendQueuedEvents()
			{
				Il2CppClassPointerStore<PreUpdate.IMGUISendQueuedEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "IMGUISendQueuedEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.IMGUISendQueuedEvents>.NativeClassPtr);
			}

			// Token: 0x06003064 RID: 12388 RVA: 0x00014796 File Offset: 0x00012996
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.IMGUISendQueuedEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F4 RID: 2292
		[StructLayout(2)]
		public struct SendMouseEvents
		{
			// Token: 0x06003065 RID: 12389 RVA: 0x000147A8 File Offset: 0x000129A8
			// Note: this type is marked as 'beforefieldinit'.
			static SendMouseEvents()
			{
				Il2CppClassPointerStore<PreUpdate.SendMouseEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "SendMouseEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.SendMouseEvents>.NativeClassPtr);
			}

			// Token: 0x06003066 RID: 12390 RVA: 0x000147C8 File Offset: 0x000129C8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.SendMouseEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F5 RID: 2293
		[StructLayout(2)]
		public struct AIUpdate
		{
			// Token: 0x06003067 RID: 12391 RVA: 0x000147DA File Offset: 0x000129DA
			// Note: this type is marked as 'beforefieldinit'.
			static AIUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.AIUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "AIUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.AIUpdate>.NativeClassPtr);
			}

			// Token: 0x06003068 RID: 12392 RVA: 0x000147FA File Offset: 0x000129FA
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.AIUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F6 RID: 2294
		[StructLayout(2)]
		public struct WindUpdate
		{
			// Token: 0x06003069 RID: 12393 RVA: 0x0001480C File Offset: 0x00012A0C
			// Note: this type is marked as 'beforefieldinit'.
			static WindUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.WindUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "WindUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.WindUpdate>.NativeClassPtr);
			}

			// Token: 0x0600306A RID: 12394 RVA: 0x0001482C File Offset: 0x00012A2C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.WindUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F7 RID: 2295
		[StructLayout(2)]
		public struct UpdateVideo
		{
			// Token: 0x0600306B RID: 12395 RVA: 0x0001483E File Offset: 0x00012A3E
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateVideo()
			{
				Il2CppClassPointerStore<PreUpdate.UpdateVideo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "UpdateVideo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.UpdateVideo>.NativeClassPtr);
			}

			// Token: 0x0600306C RID: 12396 RVA: 0x0001485E File Offset: 0x00012A5E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.UpdateVideo>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F8 RID: 2296
		[StructLayout(2)]
		public struct NewInputUpdate
		{
			// Token: 0x0600306D RID: 12397 RVA: 0x00014870 File Offset: 0x00012A70
			// Note: this type is marked as 'beforefieldinit'.
			static NewInputUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.NewInputUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "NewInputUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.NewInputUpdate>.NativeClassPtr);
			}

			// Token: 0x0600306E RID: 12398 RVA: 0x00014890 File Offset: 0x00012A90
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.NewInputUpdate>.NativeClassPtr, ref this));
			}
		}
	}
}
