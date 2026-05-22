using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BE RID: 190
	public abstract class EventBase
	{
		// Token: 0x060004A1 RID: 1185 RVA: 0x000054C8 File Offset: 0x000036C8
		public static long RegisterEventType()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x000054D5 File Offset: 0x000036D5
		public virtual long eventTypeId
		{
			get
			{
				return -1L;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x000054D9 File Offset: 0x000036D9
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x000054E6 File Offset: 0x000036E6
		public long timestamp
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

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x000054F3 File Offset: 0x000036F3
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00005500 File Offset: 0x00003700
		public ulong eventId
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

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0000550D File Offset: 0x0000370D
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x0000551A File Offset: 0x0000371A
		public ulong triggerEventId
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

		// Token: 0x060004A9 RID: 1193 RVA: 0x00005527 File Offset: 0x00003727
		public void SetTriggerEventId(ulong id)
		{
			this.triggerEventId = id;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00005532 File Offset: 0x00003732
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x0000553F File Offset: 0x0000373F
		public EventBase.EventPropagation propagation
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

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0000554C File Offset: 0x0000374C
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00005559 File Offset: 0x00003759
		public PropagationPaths path
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

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00005566 File Offset: 0x00003766
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00005573 File Offset: 0x00003773
		public EventBase.LifeCycleStatus lifeCycleStatus
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

		// Token: 0x060004B0 RID: 1200 RVA: 0x00005580 File Offset: 0x00003780
		public virtual void PreDispatch()
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00005583 File Offset: 0x00003783
		public virtual void PreDispatch(IPanel panel)
		{
			this.PreDispatch();
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000558D File Offset: 0x0000378D
		public virtual void PostDispatch()
		{
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00005590 File Offset: 0x00003790
		public virtual void PostDispatch(IPanel panel)
		{
			this.PostDispatch();
			this.processed = true;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x0000B584 File Offset: 0x00009784
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x0000B5A4 File Offset: 0x000097A4
		public bool bubbles
		{
			get
			{
				return (this.propagation & EventBase.EventPropagation.Bubbles) > EventBase.EventPropagation.None;
			}
			set
			{
				if (value)
				{
					this.propagation |= EventBase.EventPropagation.Bubbles;
				}
				else
				{
					this.propagation &= (EventBase.EventPropagation)(-2);
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0000B5DC File Offset: 0x000097DC
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x0000B5FC File Offset: 0x000097FC
		public bool tricklesDown
		{
			get
			{
				return (this.propagation & EventBase.EventPropagation.TricklesDown) > EventBase.EventPropagation.None;
			}
			set
			{
				if (value)
				{
					this.propagation |= EventBase.EventPropagation.TricklesDown;
				}
				else
				{
					this.propagation &= (EventBase.EventPropagation)(-3);
				}
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x000055A2 File Offset: 0x000037A2
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x000055AF File Offset: 0x000037AF
		public IEventHandler leafTarget
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

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x000055BC File Offset: 0x000037BC
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x000055C9 File Offset: 0x000037C9
		public IEventHandler target
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

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x000055D6 File Offset: 0x000037D6
		public List<IEventHandler> skipElements
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0000B634 File Offset: 0x00009834
		public bool Skip(IEventHandler h)
		{
			return this.skipElements.Contains(h);
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0000B654 File Offset: 0x00009854
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x0000B674 File Offset: 0x00009874
		public bool isPropagationStopped
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.PropagationStopped) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.PropagationStopped;
				}
				else
				{
					this.lifeCycleStatus &= (EventBase.LifeCycleStatus)(-2);
				}
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000055E3 File Offset: 0x000037E3
		public void StopPropagation()
		{
			this.isPropagationStopped = true;
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x0000B6AC File Offset: 0x000098AC
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x0000B6CC File Offset: 0x000098CC
		public bool isImmediatePropagationStopped
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.ImmediatePropagationStopped) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.ImmediatePropagationStopped;
				}
				else
				{
					this.lifeCycleStatus &= (EventBase.LifeCycleStatus)(-3);
				}
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000055EE File Offset: 0x000037EE
		public void StopImmediatePropagation()
		{
			this.isPropagationStopped = true;
			this.isImmediatePropagationStopped = true;
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0000B704 File Offset: 0x00009904
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x0000B724 File Offset: 0x00009924
		public bool isDefaultPrevented
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.DefaultPrevented) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.DefaultPrevented;
				}
				else
				{
					this.lifeCycleStatus &= (EventBase.LifeCycleStatus)(-5);
				}
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000B75C File Offset: 0x0000995C
		public void PreventDefault()
		{
			bool flag = (this.propagation & EventBase.EventPropagation.Cancellable) == EventBase.EventPropagation.Cancellable;
			if (flag)
			{
				this.isDefaultPrevented = true;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00005601 File Offset: 0x00003801
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x0000560E File Offset: 0x0000380E
		public PropagationPhase propagationPhase
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

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x0000561B File Offset: 0x0000381B
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00005628 File Offset: 0x00003828
		public virtual IEventHandler currentTarget
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

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0000B784 File Offset: 0x00009984
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x0000B7A4 File Offset: 0x000099A4
		public bool dispatch
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.Dispatching) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.Dispatching;
					this.dispatched = true;
				}
				else
				{
					this.lifeCycleStatus &= (EventBase.LifeCycleStatus)(-9);
				}
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00005635 File Offset: 0x00003835
		public void MarkReceivedByDispatcher()
		{
			Debug.Assert(!this.dispatched, "Events cannot be dispatched more than once.");
			this.dispatched = true;
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x0000B7E4 File Offset: 0x000099E4
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x0000B808 File Offset: 0x00009A08
		public bool dispatched
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.Dispatched) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.Dispatched;
				}
				else
				{
					this.lifeCycleStatus &= (EventBase.LifeCycleStatus)(-513);
				}
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0000B848 File Offset: 0x00009A48
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x0000B86C File Offset: 0x00009A6C
		public bool processed
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.Processed) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.Processed;
				}
				else
				{
					this.lifeCycleStatus &= (EventBase.LifeCycleStatus)(-1025);
				}
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x0000B8AC File Offset: 0x00009AAC
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		public bool processedByFocusController
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.ProcessedByFocusController) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.ProcessedByFocusController;
				}
				else
				{
					this.lifeCycleStatus &= (EventBase.LifeCycleStatus)(-2049);
				}
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0000B910 File Offset: 0x00009B10
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x0000B930 File Offset: 0x00009B30
		public bool stopDispatch
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.StopDispatch) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.StopDispatch;
				}
				else
				{
					this.lifeCycleStatus &= (EventBase.LifeCycleStatus)(-65);
				}
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0000B96C File Offset: 0x00009B6C
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0000B990 File Offset: 0x00009B90
		public bool propagateToIMGUI
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.PropagateToIMGUI) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.PropagateToIMGUI;
				}
				else
				{
					this.lifeCycleStatus &= (EventBase.LifeCycleStatus)(-129);
				}
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x0000B9F0 File Offset: 0x00009BF0
		public bool imguiEventIsValid
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.IMGUIEventIsValid) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.IMGUIEventIsValid;
				}
				else
				{
					this.lifeCycleStatus &= (EventBase.LifeCycleStatus)(-33);
				}
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00005654 File Offset: 0x00003854
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00005661 File Offset: 0x00003861
		public Event imguiEvent
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

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x0000566E File Offset: 0x0000386E
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x0000567B File Offset: 0x0000387B
		public Vector2 originalMousePosition
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

		// Token: 0x060004DE RID: 1246 RVA: 0x00005688 File Offset: 0x00003888
		public virtual void Init()
		{
			this.LocalInit();
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00005692 File Offset: 0x00003892
		public void LocalInit()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0000BA2C File Offset: 0x00009C2C
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x0000BA4C File Offset: 0x00009C4C
		public bool pooled
		{
			get
			{
				return (this.lifeCycleStatus & EventBase.LifeCycleStatus.Pooled) > EventBase.LifeCycleStatus.None;
			}
			set
			{
				if (value)
				{
					this.lifeCycleStatus |= EventBase.LifeCycleStatus.Pooled;
				}
				else
				{
					this.lifeCycleStatus &= (EventBase.LifeCycleStatus)(-17);
				}
			}
		}

		// Token: 0x020001F2 RID: 498
		public enum EventPropagation
		{
			// Token: 0x04000246 RID: 582
			None,
			// Token: 0x04000247 RID: 583
			Bubbles,
			// Token: 0x04000248 RID: 584
			TricklesDown,
			// Token: 0x04000249 RID: 585
			Cancellable = 4
		}

		// Token: 0x020001F3 RID: 499
		public enum LifeCycleStatus
		{
			// Token: 0x0400024B RID: 587
			None,
			// Token: 0x0400024C RID: 588
			PropagationStopped,
			// Token: 0x0400024D RID: 589
			ImmediatePropagationStopped,
			// Token: 0x0400024E RID: 590
			DefaultPrevented = 4,
			// Token: 0x0400024F RID: 591
			Dispatching = 8,
			// Token: 0x04000250 RID: 592
			Pooled = 16,
			// Token: 0x04000251 RID: 593
			IMGUIEventIsValid = 32,
			// Token: 0x04000252 RID: 594
			StopDispatch = 64,
			// Token: 0x04000253 RID: 595
			PropagateToIMGUI = 128,
			// Token: 0x04000254 RID: 596
			Dispatched = 512,
			// Token: 0x04000255 RID: 597
			Processed = 1024,
			// Token: 0x04000256 RID: 598
			ProcessedByFocusController = 2048
		}
	}
}
