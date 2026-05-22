using System;
using System.Runtime.InteropServices;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000033 RID: 51
	public abstract class BaseVisualElementPanel
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00002830 File Offset: 0x00000A30
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002842 File Offset: 0x00000A42
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000284F File Offset: 0x00000A4F
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000285C File Offset: 0x00000A5C
		public float scale
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00002869 File Offset: 0x00000A69
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002876 File Offset: 0x00000A76
		public float pixelsPerPoint
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00002883 File Offset: 0x00000A83
		public float scaledPixelsPerPoint
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00002890 File Offset: 0x00000A90
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000289D File Offset: 0x00000A9D
		public float sortingPriority
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000028AA File Offset: 0x00000AAA
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000028B7 File Offset: 0x00000AB7
		public PanelClearFlags clearFlags
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000028C4 File Offset: 0x00000AC4
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000028D1 File Offset: 0x00000AD1
		public bool duringLayoutPhase
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00008D18 File Offset: 0x00006F18
		public bool isDirty
		{
			get
			{
				return this.version != this.repaintVersion;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000028DE File Offset: 0x00000ADE
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x000028EB File Offset: 0x00000AEB
		public virtual RepaintData repaintData
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000028F8 File Offset: 0x00000AF8
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002905 File Offset: 0x00000B05
		public virtual ICursorManager cursorManager
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00002912 File Offset: 0x00000B12
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000291F File Offset: 0x00000B1F
		public ContextualMenuManager contextualMenuManager
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000292C File Offset: 0x00000B2C
		public void SendEvent(EventBase e, [Optional] DispatchMode dispatchMode)
		{
			Debug.Assert(this.dispatcher != null);
			EventDispatcher dispatcher = this.dispatcher;
			if (dispatcher != null)
			{
				dispatcher.Dispatch(e, this, dispatchMode);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002953 File Offset: 0x00000B53
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002960 File Offset: 0x00000B60
		public bool disposed
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000296D File Offset: 0x00000B6D
		public VisualElement GetTopElementUnderPointer(int pointerId)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000297A File Offset: 0x00000B7A
		public VisualElement RecomputeTopElementUnderPointer(Vector2 pointerPos, EventBase triggerEvent)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002987 File Offset: 0x00000B87
		public void ClearCachedElementUnderPointer(EventBase triggerEvent)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002994 File Offset: 0x00000B94
		public void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000029A1 File Offset: 0x00000BA1
		public void CommitElementUnderPointers()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00008D3C File Offset: 0x00006F3C
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000029AE File Offset: 0x00000BAE
		public virtual Shader standardWorldSpaceShader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000029B1 File Offset: 0x00000BB1
		public void InvokeStandardShaderChanged()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000029BE File Offset: 0x00000BBE
		public void InvokeStandardWorldSpaceShaderChanged()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000029CB File Offset: 0x00000BCB
		public void add_updateMaterial(Action<Material> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000029D8 File Offset: 0x00000BD8
		public void remove_updateMaterial(Action<Material> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000029E5 File Offset: 0x00000BE5
		public void InvokeUpdateMaterial(Material mat)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000029F2 File Offset: 0x00000BF2
		public void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000029FF File Offset: 0x00000BFF
		public void add_beforeUpdate(Action<IPanel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002A0C File Offset: 0x00000C0C
		public void remove_beforeUpdate(Action<IPanel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002A19 File Offset: 0x00000C19
		public void InvokeBeforeUpdate()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002A26 File Offset: 0x00000C26
		public void UpdateElementUnderPointers()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002A33 File Offset: 0x00000C33
		public virtual void Update()
		{
			this.scheduler.UpdateScheduledEvents();
			this.ValidateLayout();
			this.UpdateAnimations();
			this.UpdateBindings();
		}
	}
}
