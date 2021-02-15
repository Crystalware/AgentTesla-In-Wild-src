using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using College_Management_System.My;
using Microsoft.VisualBasic.CompilerServices;

namespace College_Management_System
{
	// Token: 0x02000013 RID: 19
	[DesignerGenerated]
	public class Form3 : Form
	{
		// Token: 0x06000120 RID: 288 RVA: 0x000118CC File Offset: 0x0000FACC
		public Form3()
		{
			for (;;)
			{
				IL_AE:
				int num = 7;
				int num2 = Form7.mqgfoefwabbyeu(31);
				for (;;)
				{
					num2 ^= 59;
					for (;;)
					{
						IL_3D:
						int num3 = 6;
						int num4 = 121;
						for (;;)
						{
							switch (num4 ^ 70)
							{
							case 60:
								goto IL_3D;
							case 61:
								switch (num3)
								{
								case 65:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form3.get_cmdReturn()).MethodHandle;
									num3 = 4;
									goto IL_1F;
								}
								case 66:
									break;
								case 67:
									switch (num2 + 61)
									{
									case 0:
										goto IL_AE;
									case 1:
										switch (num)
										{
										case 65:
											num = 2;
											goto IL_11;
										case 66:
											this.con = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000514-0000-0010-8000-00AA006D2EA4")));
											num = 3;
											goto IL_11;
										case 67:
											this.rs = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000535-0000-0010-8000-00AA006D2EA4")));
											num = 5;
											goto IL_11;
										case 68:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form3.set_cmdLecturer(Button)).MethodHandle;
											num = 4;
											goto IL_11;
										}
										case 69:
											this.bibbotbvvfruol();
											num = 6;
											goto IL_11;
										case 70:
											num = 8;
											goto IL_11;
										case 71:
											base.Load += this.bibbotbvvfruom;
											num = 1;
											goto IL_11;
										case 72:
											return;
										}
										goto Block_3;
									case 2:
										goto IL_EE;
									case 3:
										break;
									default:
										num3 = 7;
										goto IL_1F;
									}
									IL_11:
									num ^= 64;
									break;
								case 68:
									goto IL_A9;
								default:
									num4 = 122;
									continue;
								}
								num2 = Form7.mqgfoefwabbyeu(25);
								num3 = 1;
								goto IL_1F;
							case 62:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form3.bibbotbvvfruom(object, EventArgs)).MethodHandle;
								num4 = 120;
								continue;
							}
							case 63:
								goto IL_1F;
							}
							IL_38:
							num4 = 123;
							continue;
							IL_1F:
							num3 ^= 69;
							goto IL_38;
						}
					}
					IL_A9:
					continue;
					Block_3:
					num2 = -8;
					continue;
					IL_EE:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form3.bibbotbvvfruop(object, EventArgs)).MethodHandle;
					num2 = -2;
				}
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00011AA4 File Offset: 0x0000FCA4
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					for (;;)
					{
						IL_120:
						int num = Form7.mqgfoefwabbyeu(25);
						int num2 = -123;
						for (;;)
						{
							num2 ^= 68;
							for (;;)
							{
								IL_85:
								int num3 = 10;
								int num4 = -11;
								for (;;)
								{
									num4 ^= 72;
									switch (num4 + 70)
									{
									case 0:
										goto IL_85;
									case 1:
										switch (num3)
										{
										case 71:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form3.set_cmdLecturer(Button)).MethodHandle;
											num3 = 5;
											goto IL_4F;
										}
										case 72:
											switch (num2 + 66)
											{
											case 0:
												switch (num + 62)
												{
												case 0:
												{
													RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form3.bibbotbvvfruoq(object, EventArgs)).MethodHandle;
													num = -2;
													goto IL_3E;
												}
												case 1:
													this.components.Dispose();
													num = -8;
													goto IL_3E;
												case 2:
													num = Form12.wsyoqrrjsoniul(51);
													goto IL_3E;
												case 3:
													goto IL_1A0;
												}
												goto Block_6;
											case 1:
												goto IL_120;
											case 2:
												goto IL_139;
											case 3:
												break;
											default:
												num3 = 11;
												goto IL_4F;
											}
											IL_3E:
											num ^= 60;
											break;
										case 73:
											break;
										case 74:
											goto IL_FA;
										default:
											num4 = Form12.wsyoqrrjsoniul(53);
											continue;
										}
										num2 = Form2.uwpnsrqhswlmjh(44);
										num3 = 8;
										break;
									case 2:
									{
										RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form3.bibbotbvvfruom(object, EventArgs)).MethodHandle;
										num4 = -12;
										continue;
									}
									case 3:
										break;
									default:
										IL_7A:
										num4 = Form7.mqgfoefwabbyeu(21);
										continue;
									}
									IL_4F:
									num3 ^= 66;
									goto IL_7A;
								}
							}
							IL_FA:
							continue;
							Block_6:
							num2 = -5;
							continue;
							IL_139:
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form3.get_cmdStudent()).MethodHandle;
							num2 = Form10.pdqangwdsoatqb(65);
						}
					}
					IL_1A0:;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00011C7C File Offset: 0x0000FE7C
		[DebuggerStepThrough]
		private void bibbotbvvfruol()
		{
			for (;;)
			{
				int num = Form10.pdqangwdsoatqb(65);
				for (;;)
				{
					num ^= 71;
					switch (num + 61)
					{
					case 0:
					{
						ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form3));
						this.cmdProfile = new Button();
						this.cmdReturn = new Button();
						this.cmdLecturer = new Button();
						num = -98;
						continue;
					}
					case 1:
						this.lblHello.TabIndex = 19;
						this.lblHello.Text = "Hello";
						base.AutoScaleDimensions = new SizeF(8f, 16f);
						num = -108;
						continue;
					case 2:
						this.cmdProfile.TabIndex = 24;
						this.cmdProfile.Text = "ADMINS";
						this.cmdProfile.UseVisualStyleBackColor = false;
						num = -119;
						continue;
					case 3:
						this.cmdLecturer.UseVisualStyleBackColor = false;
						this.cmdStudent.BackColor = Color.Purple;
						this.cmdStudent.ForeColor = Color.White;
						num = -117;
						continue;
					case 4:
						this.cmdStudent.TabIndex = 21;
						this.cmdStudent.Text = "STUDENTS";
						this.cmdStudent.UseVisualStyleBackColor = false;
						num = Form10.pdqangwdsoatqb(76);
						continue;
					case 5:
						this.cmdLecturer.Size = new Size(195, 32);
						this.cmdLecturer.TabIndex = 22;
						this.cmdLecturer.Text = "LECTURERS";
						num = -127;
						continue;
					case 6:
						this.Text = "Form3";
						base.ResumeLayout(false);
						base.PerformLayout();
						num = -100;
						continue;
					case 7:
						for (;;)
						{
							int num2 = 4;
							for (;;)
							{
								switch (num2 ^ 75)
								{
								case 74:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form3.bibbotbvvfruoq(object, EventArgs)).MethodHandle;
									num2 = 1;
									continue;
								}
								case 75:
									this.cmdProfile.Name = "cmdProfile";
									num2 = 6;
									continue;
								case 76:
									this.cmdProfile.Size = new Size(195, 32);
									num2 = 27;
									continue;
								case 77:
									num2 = 7;
									continue;
								case 78:
									num2 = 0;
									continue;
								case 79:
									this.cmdProfile.Location = new Point(93, 114);
									num2 = 5;
									continue;
								case 80:
									num = -126;
									num2 = 26;
									continue;
								case 81:
									goto IL_254;
								}
								break;
							}
						}
						IL_254:
						continue;
					case 8:
						base.SuspendLayout();
						this.cmdProfile.BackColor = Color.Purple;
						this.cmdProfile.ForeColor = Color.White;
						num = -115;
						continue;
					case 9:
						this.cmdStudent.Location = new Point(93, 178);
						this.cmdStudent.Name = "cmdStudent";
						this.cmdStudent.Size = new Size(195, 32);
						num = -128;
						continue;
					case 10:
						for (;;)
						{
							int num3 = Form12.wsyoqrrjsoniul(51);
							for (;;)
							{
								num3 ^= 79;
								switch (num3 + 75)
								{
								case 0:
									base.Margin = new Padding(4, 4, 4, 4);
									num3 = Form7.mqgfoefwabbyeu(27);
									continue;
								case 1:
									this.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
									num3 = -9;
									continue;
								case 2:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form3.set_cmdReturn(Button)).MethodHandle;
									num3 = -8;
									continue;
								}
								case 3:
									num3 = -6;
									continue;
								case 4:
									base.Name = "Form3";
									num3 = -12;
									continue;
								case 5:
									num3 = -10;
									continue;
								case 6:
									num = -114;
									num3 = -13;
									continue;
								case 7:
									goto IL_37F;
								}
								break;
							}
						}
						IL_37F:
						continue;
					case 11:
						this.cmdReturn.BackColor = Color.Purple;
						this.cmdReturn.ForeColor = Color.White;
						this.cmdReturn.Location = new Point(93, 302);
						num = -99;
						continue;
					case 12:
						base.Controls.Add(this.cmdProfile);
						base.Controls.Add(this.cmdReturn);
						base.Controls.Add(this.cmdLecturer);
						num = -107;
						continue;
					case 13:
						this.Label2.Text = "Click a Button to do an Activity";
						this.lblHello.AutoSize = true;
						this.lblHello.BackColor = Color.FromArgb(0, 192, 0);
						num = -111;
						continue;
					case 14:
						for (;;)
						{
							int num4 = Form12.wsyoqrrjsoniul(56);
							for (;;)
							{
								num4 ^= 80;
								switch (num4 + 77)
								{
								case 0:
									num = -97;
									num4 = -22;
									continue;
								case 1:
									num4 = -26;
									continue;
								case 2:
									this.Label2.AutoSize = true;
									num4 = -24;
									continue;
								case 3:
									this.Label2.Location = new Point(90, 66);
									num4 = -29;
									continue;
								case 4:
									this.Label2.BackColor = Color.FromArgb(192, 192, 0);
									num4 = -28;
									continue;
								case 5:
									num4 = Form2.uwpnsrqhswlmjh(50);
									continue;
								case 6:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form3.set_cmdReturn(Button)).MethodHandle;
									num4 = -23;
									continue;
								}
								case 7:
									goto IL_4F4;
								}
								break;
							}
						}
						IL_4F4:
						continue;
					case 15:
						base.Controls.Add(this.cmdStudent);
						base.Controls.Add(this.Label2);
						base.Controls.Add(this.lblHello);
						num = -118;
						continue;
					case 16:
					{
						base.AutoScaleMode = AutoScaleMode.Font;
						ComponentResourceManager componentResourceManager;
						this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
						base.ClientSize = new Size(379, 354);
						num = -120;
						continue;
					}
					case 17:
						this.cmdReturn.Text = "RETURN";
						this.cmdReturn.UseVisualStyleBackColor = false;
						this.cmdLecturer.BackColor = Color.Purple;
						num = -112;
						continue;
					case 18:
					{
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form3.bibbotbvvfruon(object, EventArgs)).MethodHandle;
						num = -110;
						continue;
					}
					case 19:
						this.lblHello.Location = new Point(137, 20);
						this.lblHello.Name = "lblHello";
						this.lblHello.Size = new Size(40, 17);
						num = -125;
						continue;
					case 20:
						this.cmdLecturer.ForeColor = Color.White;
						this.cmdLecturer.Location = new Point(93, 243);
						this.cmdLecturer.Name = "cmdLecturer";
						num = -113;
						continue;
					case 21:
						this.Label2.Name = "Label2";
						this.Label2.Size = new Size(198, 17);
						this.Label2.TabIndex = 20;
						num = -105;
						continue;
					case 22:
						this.cmdStudent = new Button();
						this.Label2 = new Label();
						this.lblHello = new Label();
						num = -116;
						continue;
					case 23:
						this.cmdReturn.Name = "cmdReturn";
						this.cmdReturn.Size = new Size(195, 32);
						this.cmdReturn.TabIndex = 23;
						num = -109;
						continue;
					case 24:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000123FD File Offset: 0x000105FD
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0001240C File Offset: 0x0001060C
		internal virtual Button cmdProfile
		{
			[CompilerGenerated]
			get
			{
				return this._cmdProfile;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.bibbotbvvfruon);
				Button cmdProfile = this._cmdProfile;
				if (cmdProfile != null)
				{
					cmdProfile.Click -= value2;
				}
				this._cmdProfile = value;
				cmdProfile = this._cmdProfile;
				if (cmdProfile != null)
				{
					cmdProfile.Click += value2;
				}
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00012477 File Offset: 0x00010677
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00012488 File Offset: 0x00010688
		internal virtual Button cmdReturn
		{
			[CompilerGenerated]
			get
			{
				return this._cmdReturn;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.bibbotbvvfruoq);
				Button cmdReturn = this._cmdReturn;
				if (cmdReturn != null)
				{
					cmdReturn.Click -= value2;
				}
				this._cmdReturn = value;
				cmdReturn = this._cmdReturn;
				if (cmdReturn != null)
				{
					cmdReturn.Click += value2;
				}
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000127 RID: 295 RVA: 0x000124F3 File Offset: 0x000106F3
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00012504 File Offset: 0x00010704
		internal virtual Button cmdLecturer
		{
			[CompilerGenerated]
			get
			{
				return this._cmdLecturer;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.bibbotbvvfruop);
				Button cmdLecturer = this._cmdLecturer;
				if (cmdLecturer != null)
				{
					cmdLecturer.Click -= value2;
				}
				this._cmdLecturer = value;
				cmdLecturer = this._cmdLecturer;
				if (cmdLecturer != null)
				{
					cmdLecturer.Click += value2;
				}
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0001256F File Offset: 0x0001076F
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00012580 File Offset: 0x00010780
		internal virtual Button cmdStudent
		{
			[CompilerGenerated]
			get
			{
				return this._cmdStudent;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.bibbotbvvfruoo);
				Button cmdStudent = this._cmdStudent;
				if (cmdStudent != null)
				{
					cmdStudent.Click -= value2;
				}
				this._cmdStudent = value;
				cmdStudent = this._cmdStudent;
				if (cmdStudent != null)
				{
					cmdStudent.Click += value2;
				}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000125EB File Offset: 0x000107EB
		// (set) Token: 0x0600012C RID: 300 RVA: 0x000125F9 File Offset: 0x000107F9
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00012606 File Offset: 0x00010806
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00012614 File Offset: 0x00010814
		internal virtual Label lblHello { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600012F RID: 303 RVA: 0x00012624 File Offset: 0x00010824
		private void bibbotbvvfruom(object bo, EventArgs bp)
		{
			for (;;)
			{
				IL_B6:
				int num = Form7.mqgfoefwabbyeu(21);
				int num2 = 4;
				for (;;)
				{
					num2 ^= 80;
					for (;;)
					{
						IL_42:
						int num3 = Form7.mqgfoefwabbyeu(25);
						int num4 = -24;
						for (;;)
						{
							num4 ^= 81;
							switch (num4 + 74)
							{
							case 0:
								goto IL_42;
							case 1:
								switch (num3 + 78)
								{
								case 0:
									switch (num2)
									{
									case 81:
										goto IL_B6;
									case 82:
										switch (num + 76)
										{
										case 0:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form3.get_cmdStudent()).MethodHandle;
											num = -2;
											goto IL_0B;
										}
										case 1:
											this.rs.Open("Select * from AdminsProfile", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
											num = -16;
											goto IL_0B;
										case 2:
										{
											string str;
											this.lblHello.Text = this.lblHello.Text + ", " + str + "!";
											num = -15;
											goto IL_0B;
										}
										case 3:
											num = -1;
											goto IL_0B;
										case 4:
										{
											string str = Conversions.ToString(this.rs.Fields["FirstName"].Value);
											num = -4;
											goto IL_0B;
										}
										case 5:
											this.con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\Joey\\Documents\\College.mdb; Persist Security Info = False", "", "", -1);
											num = Form7.mqgfoefwabbyeu(31);
											goto IL_0B;
										case 6:
											num = -14;
											goto IL_0B;
										case 7:
											num = -10;
											goto IL_0B;
										case 8:
											return;
										}
										goto Block_2;
									case 83:
										goto IL_F9;
									case 84:
										break;
									default:
										num3 = -7;
										goto IL_1C;
									}
									IL_0B:
									num ^= 74;
									break;
								case 1:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form3.bibbotbvvfruoq(object, EventArgs)).MethodHandle;
									num3 = Form7.mqgfoefwabbyeu(24);
									goto IL_1C;
								}
								case 2:
									break;
								case 3:
									goto IL_B1;
								default:
									num4 = Form2.uwpnsrqhswlmjh(50);
									continue;
								}
								num2 = 2;
								num3 = -8;
								goto IL_1C;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form3.bibbotbvvfruol()).MethodHandle;
								num4 = -23;
								continue;
							}
							case 3:
								goto IL_1C;
							}
							IL_37:
							num4 = Form12.wsyoqrrjsoniul(49);
							continue;
							IL_1C:
							num3 ^= 77;
							goto IL_37;
						}
					}
					IL_B1:
					continue;
					Block_2:
					num2 = 1;
					continue;
					IL_F9:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form3.set_cmdReturn(Button)).MethodHandle;
					num2 = 3;
				}
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0001284C File Offset: 0x00010A4C
		private void bibbotbvvfruon(object bq, EventArgs br)
		{
			for (;;)
			{
				IL_8C:
				int num = Form2.uwpnsrqhswlmjh(34);
				int num2 = 0;
				for (;;)
				{
					num2 ^= 77;
					for (;;)
					{
						IL_51:
						int num3 = 29;
						int num4 = 2;
						for (;;)
						{
							switch (num4 ^ 81)
							{
							case 80:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form3.bibbotbvvfruop(object, EventArgs)).MethodHandle;
								num4 = 1;
								continue;
							}
							case 81:
								switch (num3)
								{
								case 76:
									break;
								case 77:
									switch (num2)
									{
									case 74:
										goto IL_8C;
									case 75:
										goto IL_9B;
									case 76:
										switch (num + 71)
										{
										case 0:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form3.get_lblHello()).MethodHandle;
											num = -1;
											goto IL_0B;
										}
										case 1:
											num = -8;
											goto IL_0B;
										case 2:
											num = Form2.uwpnsrqhswlmjh(44);
											goto IL_0B;
										case 3:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxj.Show();
											num = -4;
											goto IL_0B;
										case 4:
											base.Hide();
											num = -3;
											goto IL_0B;
										case 5:
											return;
										}
										goto Block_2;
									case 77:
										break;
									default:
										num3 = 28;
										goto IL_19;
									}
									IL_0B:
									num ^= 70;
									break;
								case 78:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form3.get_lblHello()).MethodHandle;
									num3 = 30;
									goto IL_19;
								}
								case 79:
									goto IL_8A;
								default:
									num4 = 3;
									continue;
								}
								num2 = 1;
								num3 = 31;
								goto IL_19;
							case 82:
								goto IL_51;
							case 83:
								goto IL_19;
							}
							IL_32:
							num4 = 0;
							continue;
							IL_19:
							num3 ^= 80;
							goto IL_32;
						}
					}
					IL_8A:
					continue;
					IL_9B:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form3.get_cmdReturn()).MethodHandle;
					num2 = 6;
					continue;
					Block_2:
					num2 = 7;
				}
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000129C0 File Offset: 0x00010BC0
		private void bibbotbvvfruoo(object bs, EventArgs bt)
		{
			for (;;)
			{
				IL_CC:
				int num = 5;
				int num2 = -8;
				for (;;)
				{
					num2 ^= 74;
					for (;;)
					{
						IL_51:
						int num3 = 19;
						int num4 = 1;
						for (;;)
						{
							switch (num4 ^ 74)
							{
							case 72:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form3.bibbotbvvfruoq(object, EventArgs)).MethodHandle;
								num4 = 2;
								continue;
							}
							case 73:
								switch (num3)
								{
								case 82:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form3.get_cmdProfile()).MethodHandle;
									num3 = 21;
									goto IL_19;
								}
								case 83:
									break;
								case 84:
									switch (num2 + 81)
									{
									case 0:
										switch (num)
										{
										case 72:
											num = 2;
											goto IL_0B;
										case 73:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxk.Show();
											num = 7;
											goto IL_0B;
										case 74:
											base.Hide();
											num = 4;
											goto IL_0B;
										case 75:
											num = 6;
											goto IL_0B;
										case 76:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form3.set_lblHello(Label)).MethodHandle;
											num = 3;
											goto IL_0B;
										}
										case 77:
											return;
										}
										goto Block_2;
									case 1:
										goto IL_BE;
									case 2:
										goto IL_CC;
									case 3:
										break;
									default:
										num3 = 20;
										goto IL_19;
									}
									IL_0B:
									num ^= 79;
									break;
								case 85:
									goto IL_90;
								default:
									num4 = 0;
									continue;
								}
								num2 = Form12.wsyoqrrjsoniul(56);
								num3 = 18;
								goto IL_19;
							case 74:
								goto IL_51;
							case 75:
								goto IL_19;
							}
							IL_32:
							num4 = 3;
							continue;
							IL_19:
							num3 ^= 71;
							goto IL_32;
						}
					}
					IL_90:
					continue;
					Block_2:
					num2 = -5;
					continue;
					IL_BE:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form3..ctor()).MethodHandle;
					num2 = -6;
				}
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00012B30 File Offset: 0x00010D30
		private void bibbotbvvfruop(object bu, EventArgs bv)
		{
			for (;;)
			{
				IL_95:
				int num = 29;
				int num2 = -28;
				for (;;)
				{
					num2 ^= 80;
					for (;;)
					{
						IL_54:
						int num3 = 4;
						int num4 = 27;
						for (;;)
						{
							switch (num4 ^ 80)
							{
							case 72:
								switch (num3)
								{
								case 72:
									break;
								case 73:
									switch (num2 + 79)
									{
									case 0:
										goto IL_95;
									case 1:
										goto IL_A0;
									case 2:
										switch (num)
										{
										case 75:
											num = 30;
											goto IL_0B;
										case 76:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form3.bibbotbvvfruop(object, EventArgs)).MethodHandle;
											num = 28;
											goto IL_0B;
										}
										case 77:
											base.Hide();
											num = 27;
											goto IL_0B;
										case 78:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxa.Show();
											num = 31;
											goto IL_0B;
										case 79:
											num = 0;
											goto IL_0B;
										case 80:
											return;
										}
										goto Block_2;
									case 3:
										break;
									default:
										num3 = 5;
										goto IL_19;
									}
									IL_0B:
									num ^= 80;
									break;
								case 74:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form3.Dispose(bool)).MethodHandle;
									num3 = 7;
									goto IL_19;
								}
								case 75:
									goto IL_90;
								default:
									num4 = 26;
									continue;
								}
								num2 = Form12.wsyoqrrjsoniul(52);
								num3 = 6;
								goto IL_19;
							case 73:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form3.bibbotbvvfruol()).MethodHandle;
								num4 = 25;
								continue;
							}
							case 74:
								goto IL_54;
							case 75:
								goto IL_19;
							}
							IL_32:
							num4 = 24;
							continue;
							IL_19:
							num3 ^= 77;
							goto IL_32;
						}
					}
					IL_90:
					continue;
					IL_A0:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form3.set_cmdProfile(Button)).MethodHandle;
					num2 = Form6.sbdifomqugmuko(61);
					continue;
					Block_2:
					num2 = -31;
				}
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00012CAC File Offset: 0x00010EAC
		private void bibbotbvvfruoq(object bw, EventArgs bx)
		{
			for (;;)
			{
				IL_AB:
				int num = 25;
				int num2 = 31;
				for (;;)
				{
					num2 ^= 81;
					for (;;)
					{
						IL_5E:
						int num3 = Form2.uwpnsrqhswlmjh(42);
						int num4 = -7;
						for (;;)
						{
							num4 ^= 78;
							switch (num4 + 76)
							{
							case 0:
								switch (num3 + 75)
								{
								case 0:
									break;
								case 1:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form3.set_cmdLecturer(Button)).MethodHandle;
									num3 = -3;
									goto IL_19;
								}
								case 2:
									switch (num2)
									{
									case 75:
										goto IL_AB;
									case 76:
										switch (num)
										{
										case 81:
											base.Hide();
											num = 29;
											goto IL_0B;
										case 82:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form3.set_cmdReturn(Button)).MethodHandle;
											num = 26;
											goto IL_0B;
										}
										case 83:
											num = 30;
											goto IL_0B;
										case 84:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelwz.Show();
											num = 27;
											goto IL_0B;
										case 85:
											num = 28;
											goto IL_0B;
										case 86:
											return;
										}
										goto Block_2;
									case 77:
										goto IL_DF;
									case 78:
										break;
									default:
										num3 = Form7.mqgfoefwabbyeu(24);
										goto IL_19;
									}
									IL_0B:
									num ^= 72;
									break;
								case 3:
									goto IL_A6;
								default:
									num4 = Form12.wsyoqrrjsoniul(40);
									continue;
								}
								num2 = 29;
								num3 = -13;
								goto IL_19;
							case 1:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form3..ctor()).MethodHandle;
								num4 = -5;
								continue;
							}
							case 2:
								goto IL_5E;
							case 3:
								goto IL_19;
							}
							IL_32:
							num4 = Form2.uwpnsrqhswlmjh(44);
							continue;
							IL_19:
							num3 ^= 75;
							goto IL_32;
						}
					}
					IL_A6:
					continue;
					Block_2:
					num2 = 26;
					continue;
					IL_DF:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form3.set_cmdProfile(Button)).MethodHandle;
					num2 = 28;
				}
			}
		}

		// Token: 0x0400007F RID: 127
		private IContainer components;

		// Token: 0x04000086 RID: 134
		private Connection con;

		// Token: 0x04000087 RID: 135
		private Recordset rs;
	}
}
