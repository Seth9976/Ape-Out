using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.LowLevel
{
	// Token: 0x02000289 RID: 649
	public class PlayerLoop
	{
		// Token: 0x060022A8 RID: 8872 RVA: 0x00078470 File Offset: 0x00076670
		public static PlayerLoopSystem GetDefaultPlayerLoop()
		{
			Il2CppReferenceArray<PlayerLoopSystemInternal> defaultPlayerLoopInternal = PlayerLoop.GetDefaultPlayerLoopInternal();
			int num = 0;
			return PlayerLoop.InternalToPlayerLoopSystem(defaultPlayerLoopInternal, ref num);
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x00078494 File Offset: 0x00076694
		public static PlayerLoopSystem GetCurrentPlayerLoop()
		{
			Il2CppReferenceArray<PlayerLoopSystemInternal> currentPlayerLoopInternal = PlayerLoop.GetCurrentPlayerLoopInternal();
			int num = 0;
			return PlayerLoop.InternalToPlayerLoopSystem(currentPlayerLoopInternal, ref num);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x000784B8 File Offset: 0x000766B8
		public static void SetPlayerLoop(PlayerLoopSystem loop)
		{
			List<PlayerLoopSystemInternal> list = new List<PlayerLoopSystemInternal>();
			PlayerLoop.PlayerLoopSystemToInternal(loop, ref list);
			PlayerLoop.SetPlayerLoopInternal(list.ToArray());
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x00012833 File Offset: 0x00010A33
		public static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<PlayerLoopSystemInternal> internalSys)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x00012840 File Offset: 0x00010A40
		public static PlayerLoopSystem InternalToPlayerLoopSystem(Il2CppReferenceArray<PlayerLoopSystemInternal> internalSys, ref int offset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x000784E4 File Offset: 0x000766E4
		public static Il2CppReferenceArray<PlayerLoopSystemInternal> GetDefaultPlayerLoopInternal()
		{
			IntPtr intPtr = PlayerLoop.GetDefaultPlayerLoopInternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystemInternal>>(intPtr2) : null;
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x0007850C File Offset: 0x0007670C
		public static Il2CppReferenceArray<PlayerLoopSystemInternal> GetCurrentPlayerLoopInternal()
		{
			IntPtr intPtr = PlayerLoop.GetCurrentPlayerLoopInternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystemInternal>>(intPtr2) : null;
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x0001284D File Offset: 0x00010A4D
		public static void SetPlayerLoopInternal(Il2CppReferenceArray<PlayerLoopSystemInternal> loop)
		{
			PlayerLoop.SetPlayerLoopInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(loop));
		}

		// Token: 0x04001C8D RID: 7309
		private static readonly PlayerLoop.GetDefaultPlayerLoopInternalDelegate GetDefaultPlayerLoopInternalDelegateField = IL2CPP.ResolveICall<PlayerLoop.GetDefaultPlayerLoopInternalDelegate>("UnityEngine.LowLevel.PlayerLoop::GetDefaultPlayerLoopInternal");

		// Token: 0x04001C8E RID: 7310
		private static readonly PlayerLoop.GetCurrentPlayerLoopInternalDelegate GetCurrentPlayerLoopInternalDelegateField = IL2CPP.ResolveICall<PlayerLoop.GetCurrentPlayerLoopInternalDelegate>("UnityEngine.LowLevel.PlayerLoop::GetCurrentPlayerLoopInternal");

		// Token: 0x04001C8F RID: 7311
		private static readonly PlayerLoop.SetPlayerLoopInternalDelegate SetPlayerLoopInternalDelegateField = IL2CPP.ResolveICall<PlayerLoop.SetPlayerLoopInternalDelegate>("UnityEngine.LowLevel.PlayerLoop::SetPlayerLoopInternal");

		// Token: 0x02000BE8 RID: 3048
		// (Invoke) Token: 0x06003628 RID: 13864
		private delegate IntPtr GetDefaultPlayerLoopInternalDelegate();

		// Token: 0x02000BE9 RID: 3049
		// (Invoke) Token: 0x0600362A RID: 13866
		private delegate IntPtr GetCurrentPlayerLoopInternalDelegate();

		// Token: 0x02000BEA RID: 3050
		// (Invoke) Token: 0x0600362C RID: 13868
		private delegate void SetPlayerLoopInternalDelegate(IntPtr loop);
	}
}
