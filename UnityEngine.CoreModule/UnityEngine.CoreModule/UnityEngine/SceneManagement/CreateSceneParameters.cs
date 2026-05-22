using System;

namespace UnityEngine.SceneManagement
{
	// Token: 0x02000286 RID: 646
	[Serializable]
	public struct CreateSceneParameters
	{
		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x00078438 File Offset: 0x00076638
		// (set) Token: 0x060022A3 RID: 8867 RVA: 0x000127C8 File Offset: 0x000109C8
		public LocalPhysicsMode localPhysicsMode
		{
			get
			{
				return this.m_LocalPhysicsMode;
			}
			set
			{
				this.m_LocalPhysicsMode = value;
			}
		}

		// Token: 0x04001C87 RID: 7303
		public LocalPhysicsMode m_LocalPhysicsMode;
	}
}
