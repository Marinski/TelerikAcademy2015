<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:students="urn:students">
  <xsl:template match="/">
    <html>
      <head>
        <title>Hello XML world!</title>
        <style type="text/css">
          body {
            font-size:62.5%;
          }
          body {
          width: 99%;
            font-family: Segoe UI;
            color: #212121;
          }
          .container {
            width: 80%;
            margin: 0 auto;
          }
          table thead {
            background:#dea;
          }
          table td {
            padding: 0.2em 0.4em;
          }
        </style>
      </head>
      <body>
        <div class="container">
          <h1>This is XSL Academy Students List</h1>
        </div>
        <div class="container">
          <table border="1">
            <thead>
              <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Sex</th>
                <th>B.Date</th>
                <th>Phone</th>
                <th>Email</th>
                <th>Course</th>
                <th>Specialty</th>
                <th>F.Number</th>
              </tr>
            </thead>
            <tbody>
              <xsl:for-each select="/academy/students:students/students:student">
                <xsl:call-template name="data-row">
                  <xsl:with-param name="index" select="position()"></xsl:with-param>
                </xsl:call-template>
              </xsl:for-each>
            </tbody>
          </table>
        </div>
      </body>
    </html>
  </xsl:template>

  <xsl:template name="data-row">
    <xsl:param name="index" />
    <tr>
      <td>
        <xsl:value-of select="$index"></xsl:value-of>
      </td>
      <td>
        <xsl:value-of select="students:name" />
      </td>
      <td>
        <xsl:value-of select="students:sex" />
      </td>
      <td>
        <xsl:value-of select="students:bdate" />
      </td>
      <td>
        <xsl:value-of select="students:phone" />
      </td>
      <td>
        <xsl:value-of select="students:email" />
      </td>
      <td>
        <xsl:value-of select="students:course" />
      </td>
      <td>
        <xsl:value-of select="students:specialty" />
      </td>
      <td>
        <xsl:value-of select="students:facultyNumber" />
      </td>
    </tr>
  </xsl:template>
</xsl:stylesheet>
